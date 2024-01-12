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
    public partial class FormTenantsLogin : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;

        public FormTenantsLogin(AccountManager s, AccountType accountType)
        {
            InitializeComponent();
            studentsList = s;      
            this.accountType = accountType;

            FormNotifications formNotifications = new FormNotifications(studentsList, accountType);
            formNotifications.MdiParent = this;
            formNotifications.ControlBox = false;
            formNotifications.MaximizeBox = false;
            formNotifications.MinimizeBox = false;
            formNotifications.ShowIcon = false;
            formNotifications.Text = "";
            formNotifications.Dock = DockStyle.Fill;
            formNotifications.Show();
        }

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotifications formNotifications = new FormNotifications(studentsList, accountType);
            formNotifications.MdiParent = this;
            formNotifications.ControlBox = false;
            formNotifications.MaximizeBox = false;
            formNotifications.MinimizeBox = false;
            formNotifications.ShowIcon = false;
            formNotifications.Text = "";
            formNotifications.Dock = DockStyle.Fill;
            formNotifications.Show();           
        }

        private void tasksScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(studentsList, accountType);
            formHome.MdiParent = this;
            formHome.ControlBox = false;
            formHome.MaximizeBox = false;
            formHome.MinimizeBox = false;
            formHome.ShowIcon = false;
            formHome.Text = "";
            formHome.Dock = DockStyle.Fill;
            formHome.Show();
        }

        private void groceriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrocery formGrocery = new FormGrocery(studentsList, accountType);
            formGrocery.MdiParent = this;
            formGrocery.ControlBox = false;
            formGrocery.MaximizeBox = false;
            formGrocery.MinimizeBox = false;
            formGrocery.ShowIcon = false;
            formGrocery.Text = "";
            formGrocery.Dock = DockStyle.Fill;
            formGrocery.Show();
        }

        private void announcementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FormAnnouncements formAnnouncements = new Forms.FormAnnouncements(studentsList, accountType);
            formAnnouncements.MdiParent = this;
            formAnnouncements.ControlBox = false;
            formAnnouncements.MaximizeBox = false;
            formAnnouncements.MinimizeBox = false;
            formAnnouncements.ShowIcon = false;
            formAnnouncements.Text = "";
            formAnnouncements.Dock = DockStyle.Fill;
            formAnnouncements.Show();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FormComplaints formComplaints = new Forms.FormComplaints(studentsList, accountType);
            formComplaints.MdiParent = this;
            formComplaints.ControlBox = false;
            formComplaints.MaximizeBox = false;
            formComplaints.MinimizeBox = false;
            formComplaints.ShowIcon = false;
            formComplaints.Text = "";
            formComplaints.Dock = DockStyle.Fill;
            formComplaints.Show();
        }

        private void houseRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHouseRules formHouseRules = new FormHouseRules(studentsList, accountType);
            formHouseRules.MdiParent = this;
            formHouseRules.ControlBox = false;
            formHouseRules.MaximizeBox = false;
            formHouseRules.MinimizeBox = false;
            formHouseRules.ShowIcon = false;
            formHouseRules.Text = "";
            formHouseRules.Dock = DockStyle.Fill;
            formHouseRules.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountType = AccountType.NOACCOUNT;
            FormHome formHome = new FormHome(studentsList, accountType);
            formHome.Show();
            this.Close();
        }
    }
}

