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
    public partial class FormTenantsManagement : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;
        public FormTenantsManagement(AccountManager s, AccountType accountType)
        {
            InitializeComponent();
            studentsList = s;
            this.accountType = accountType;

            foreach(Account account in studentsList.GetStudentAccounts())
            {
                cbStudentID.Items.Add(account.StudentID);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool StudentIDAlreadyExists = false;

            foreach(var accountInList in studentsList.GetAllAccounts())
            {
                if (Convert.ToInt32(cbStudentID.Text) == accountInList.StudentID)
                {
                    StudentIDAlreadyExists = true;
                }
            }

            if (StudentIDAlreadyExists)
            {
                lblErrorMessage.Text = $"The Student ID {cbStudentID.Text} is already in use!";
                cbStudentID.Text = "";
                tbUsername.Text = "";
                tbPassword.Text = "";
            }
            else
            {
                lblErrorMessage.Text = string.Empty;
                Account account = new Account(Convert.ToInt32(cbStudentID.Text),tbUsername.Text, tbPassword.Text,AccountType.STUDENT);
                studentsList.AddToTenantList(account);
                studentsList.AddToCSVFile(account);
                cbStudentID.Items.Add(cbStudentID.Text);
                cbStudentID.Text = "";
                tbUsername.Text = "";
                tbPassword.Text = "";
                btnShowStudentInfo.PerformClick();
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

            foreach (var item in studentsList.GetAllAccounts())
            {
                if (Convert.ToInt32(cbStudentID.Text) == item.StudentID)
                {
                    studentsList.RemoveFromTenantList(item);
                    studentsList.RemoveFromCSVFile(item);
                    cbStudentID.Items.Remove(cbStudentID.Text);
                    cbStudentID.Text = "";
                    break;
                }
            }
            btnShowStudentInfo.PerformClick();
        }

        private void btnShowStudentInfo_Click(object sender, EventArgs e)
        {
            lbStudentInfo.Items.Clear();
            foreach (var item in studentsList.GetStudentAccounts())
            {
                lbStudentInfo.Items.Add("Student ID: " + Convert.ToString(item.StudentID) + " Username: " + item.Username + " Password: " + item.Password);
            }
        }

        private void btnLogClear_Click(object sender, EventArgs e)
        {
            lbStudentInfo.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdminLogin form = new FormAdminLogin(studentsList, accountType);
            form.Show();
            this.Close();
        }

        private void btnTNotification_Click(object sender, EventArgs e)
        {
            accountType = AccountType.NOACCOUNT;
            FormHome formHome = new FormHome(studentsList, accountType);
            formHome.Show();
            MdiParent.Close();
        }
    }
}
