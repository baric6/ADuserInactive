namespace ADuserInactive
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getUsers = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.domainTXT = new System.Windows.Forms.TextBox();
            this.minDays = new System.Windows.Forms.TextBox();
            this.maxDays = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getUsers
            // 
            this.getUsers.Location = new System.Drawing.Point(175, 85);
            this.getUsers.Name = "getUsers";
            this.getUsers.Size = new System.Drawing.Size(75, 23);
            this.getUsers.TabIndex = 0;
            this.getUsers.Text = "get users";
            this.getUsers.UseVisualStyleBackColor = true;
            this.getUsers.Click += new System.EventHandler(this.getUsers_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOutput.HideSelection = false;
            this.lbOutput.Location = new System.Drawing.Point(12, 144);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(549, 294);
            this.lbOutput.TabIndex = 1;
            this.lbOutput.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Domain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Days";
            // 
            // domainTXT
            // 
            this.domainTXT.Location = new System.Drawing.Point(75, 19);
            this.domainTXT.Name = "domainTXT";
            this.domainTXT.Size = new System.Drawing.Size(175, 20);
            this.domainTXT.TabIndex = 5;
            // 
            // minDays
            // 
            this.minDays.Location = new System.Drawing.Point(75, 51);
            this.minDays.Name = "minDays";
            this.minDays.Size = new System.Drawing.Size(50, 20);
            this.minDays.TabIndex = 6;
            // 
            // maxDays
            // 
            this.maxDays.Location = new System.Drawing.Point(75, 82);
            this.maxDays.Name = "maxDays";
            this.maxDays.Size = new System.Drawing.Size(50, 20);
            this.maxDays.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maxDays);
            this.groupBox1.Controls.Add(this.getUsers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minDays);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.domainTXT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 126);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbOutput);
            this.Name = "Form1";
            this.Text = "Mango AD Inactive Users";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getUsers;
        private System.Windows.Forms.ListView lbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox domainTXT;
        private System.Windows.Forms.TextBox minDays;
        private System.Windows.Forms.TextBox maxDays;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

