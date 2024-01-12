using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingApp
{
    public partial class FormLogIn : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;

        public FormLogIn(AccountManager s, AccountType accountType)
        {
            InitializeComponent();
            studentsList = s;
            this.accountType = accountType;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginCheck = false;
            foreach (var account in studentsList.GetAllAccounts())
            {
                if (tbxPassword.Text == account.Password && tbxUsername.Text == account.Username)
                {
                    accountType = account.AccountType;
                    studentsList.SetLastLogin(account);
                    if (accountType == AccountType.STUDENT)
                    {
                        FormTenantsLogin login = new FormTenantsLogin(studentsList, accountType);
                        login.Show();
                        this.Hide();
                        loginCheck = true;
                        break;
                    }
                    else if(accountType == AccountType.ADMIN)
                    {
                        FormAdminLogin login = new FormAdminLogin(studentsList, accountType);
                        login.Show();
                        this.Hide();
                        loginCheck = true;
                        break;
                    }
                }
            }

            if (!loginCheck)
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }
    }
}

