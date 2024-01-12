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
    public partial class FormNotifications : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;
        public FormNotifications(AccountManager s, AccountType accountType)
        {
            InitializeComponent();
            studentsList = s;
            this.accountType = accountType;
        }

        private void btnDeleteNotification_Click(object sender, EventArgs e)
        {
            foreach (var item in studentsList.GetAllAccounts())
            {
                if (item == studentsList.GetLastAccount())
                {
                    foreach (var notification in item.GetNotifications())
                    {
                        if (notification.DisplayNotification() == lbNotifications.SelectedItem.ToString() || notification.DisplayGroceryNotification() == lbNotifications.SelectedItem.ToString())
                        {
                            item.RemoveNotification(notification);
                            break;
                        }
                    }
                }
            }
            lbNotifications.Items.Remove(lbNotifications.SelectedItem);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormTenantsLogin Menu = new FormTenantsLogin(studentsList, accountType);
            Menu.Show();
            this.Close();
        }

        private void FormNotifications_Load(object sender, EventArgs e)
        {
            lbNotifications.Items.Clear();
            foreach (var item in studentsList.GetAllAccounts())
            {
                if (item == studentsList.GetLastAccount())
                {
                    foreach (var notification in item.GetNotifications())
                    {
                        if (notification.Description != null)
                        {
                            lbNotifications.Items.Add(notification.DisplayGroceryNotification());
                        }
                        else
                        {
                            lbNotifications.Items.Add(notification.DisplayNotification());
                        }
                    }
                }
            }
        }
    }
}
