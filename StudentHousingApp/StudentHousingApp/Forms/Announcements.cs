using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingApp.Forms
{
    public partial class FormAnnouncements : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;

        public FormAnnouncements(AccountManager s, AccountType accountType)
        {
            InitializeComponent();
            studentsList = s;
            this.accountType = accountType;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormTenantsLogin Menu = new FormTenantsLogin(studentsList, accountType);
            Menu.Show();
            this.Close();
        }

        private void btnTNotification_Click(object sender, EventArgs e)
        {
            accountType = AccountType.NOACCOUNT;
            FormHome formHome = new FormHome(studentsList, accountType);
            formHome.Show();
            MdiParent.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = txbxAnnouncement.Text;
            string date = monthCalendar.SelectionRange.Start.ToShortDateString();

            Announcement announcement = new Announcement(studentsList.GetLastAccount().Username,date, message);

            foreach (var item in studentsList.GetAllAccounts())
            {
                if (item.StudentID != studentsList.GetLastAccount().StudentID)
                {
                    Notification notification = new Notification("Announcement");
                    item.AddNotification(notification);
                }
            }

            foreach (var item in studentsList.GetAllAccounts())
            {
                item.AddAnnouncement(announcement);
            }

            lbAnnouncements.Items.Add(announcement.DisplayAnnouncement());
            txbxAnnouncement.Text = "";
        }

        private void btnDeleteNotification_Click(object sender, EventArgs e)
        {
            foreach (var item in studentsList.GetAllAccounts())
            {
                if (item.StudentID == studentsList.GetLastAccount().StudentID)
                {
                    foreach (var announcement in item.GetAnnouncement())
                    {
                        if (announcement.DisplayAnnouncement() == lbAnnouncements.SelectedItem.ToString())
                        {
                            item.RemoveAnnouncement(announcement);
                            break;
                        }
                    }
                }
            }
            lbAnnouncements.Items.Remove(lbAnnouncements.SelectedItem);
        }

        private void FormAnnouncements_Load(object sender, EventArgs e)
        {
            lbAnnouncements.Items.Clear();
            foreach (var item in studentsList.GetAllAccounts())
            {
                if (item.StudentID == studentsList.GetLastAccount().StudentID)
                {
                    foreach (var announcement in item.GetAnnouncement())
                    {
                        lbAnnouncements.Items.Add(announcement.DisplayAnnouncement());
                    }
                }
            }
        }
    }
}
