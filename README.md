# AD User Inactive Checker

## Overview

The **AD User Inactive Checker** is a C# Windows Forms application designed to retrieve and display information about inactive Active Directory users based on specified criteria. This tool provides administrators with a convenient way to identify and manage users who have been inactive for a certain period.

### Features

- Retrieve a list of Active Directory users in a specified domain.
- Filter users based on their inactivity period (minimum and maximum days).
- Display user details including username, days inactive, last sign-in date, and enabled status.

## Getting Started

### Prerequisites

- .NET Framework (version X.X or higher)
- Visual Studio (optional but recommended for development)

### Installation

1. Clone the repository to your local machine.

```
git clone https://github.com/your-username/ADuserInactive.git
```
1. Open the project in Visual Studio (or your preferred C# IDE).

2. Build and run the application.

### Usage

1. Launch the application.
2. Enter the domain name of your Active Directory in the "Domain" field.
3. Set the minimum and maximum days of inactivity.
4. Click the "Get Users" button to retrieve and display inactive users.


### How It Works

- The application utilizes the System.DirectoryServices.AccountManagement namespace to interact with Active Directory. Here's a brief overview of the code:

- The GetUsersFromActiveDirectory method retrieves a list of Active Directory users in the specified domain.

- The GetInactiveUsers method filters the users based on the specified inactivity criteria.

- The retrieved user information is displayed in a ListView control with columns for "Username," "Days Inactive," "Last Sign In," and "Enabled" status.
