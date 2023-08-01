using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADuserInactive
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbOutput.View = View.Details; // Set the view to show details (multicolumn)
            lbOutput.Columns.Add("Username", 150);
            lbOutput.Columns.Add("Days Inactive", 100);
            lbOutput.Columns.Add("Last Sign In", 200);
            lbOutput.Columns.Add("Enabled", 80);
   
            minDays.Text = "30";
            maxDays.Text = "90";
            domainTXT.Text = Environment.UserDomainName;
        }

        private void getUsers_Click(object sender, EventArgs e)
        {
            string domainName = domainTXT.Text;

            List<User> usersFromAD = GetUsersFromActiveDirectory(domainName);

            int minDaysInactive;
            int maxDaysInactive;

            if (int.Parse(minDays.Text)  < int.Parse(maxDays.Text))
            {
                if (minDays.Text == "30" && maxDays.Text == "90")
                {
                    minDaysInactive = 30;
                    maxDaysInactive = 90;
                }
                else
                {
                    minDaysInactive = int.Parse(minDays.Text);
                    maxDaysInactive = int.Parse(maxDays.Text);
                }

                List<User> inactiveUsers = GetInactiveUsers(usersFromAD, minDaysInactive, maxDaysInactive);

                DisplayUsersInListView(inactiveUsers);
            }
            else
            {
                MessageBox.Show("Max days have to be greater then Min days", "Error", MessageBoxButtons.OK);
            }
            
            

           
        }

        private void DisplayUsersInListView(List<User> users)
        {
            lbOutput.Items.Clear();
            foreach (var user in users)
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
                using (UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, user.Username))
                {
                    ListViewItem item = new ListViewItem(user.Username);
                    item.SubItems.Add($"{(int)Math.Floor((DateTime.Now - user.LastSignIn).TotalDays)} days");
                    item.SubItems.Add(user.LastSignIn.ToString());
                    item.SubItems.Add(userPrincipal?.Enabled.ToString() ?? "Unknown"); // Add the Enabled status to the new column
                    lbOutput.Items.Add(item);
                }
            }
        }

        public List<User> GetUsersFromActiveDirectory(string domainName)
        {
            List<User> users = new List<User>();

            using (PrincipalContext context = new PrincipalContext(ContextType.Domain, domainName))
            using (UserPrincipal userPrincipal = new UserPrincipal(context))
            using (PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal))
            {
                foreach (var user in searcher.FindAll())
                {
                    if (user is UserPrincipal userPrincipalResult)
                    {
                        users.Add(new User { Username = userPrincipalResult.SamAccountName, LastSignIn = userPrincipalResult.LastLogon ?? DateTime.MinValue });
                    }
                }
            }

            return users;
        }

        public static List<User> GetInactiveUsers(List<User> userList, int minDaysInactive, int maxDaysInactive)
        {
            DateTime today = DateTime.Now;

            List<User> inactiveUsers = userList
                .Where(user => (today - user.LastSignIn).TotalDays >= minDaysInactive
                            && (today - user.LastSignIn).TotalDays <= maxDaysInactive)
                .ToList();

            return inactiveUsers;
        }

    }
    public class User
    {
        public string Username { get; set; }
        public DateTime LastSignIn { get; set; }
    }
}
