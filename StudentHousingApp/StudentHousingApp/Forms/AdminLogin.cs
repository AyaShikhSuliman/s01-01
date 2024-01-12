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

    public partial class FormAdminLogin : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;

        public FormAdminLogin(AccountManager s, AccountType accountType)
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

        private void btnANotification_Click(object sender, EventArgs e)
        {
            FormHome enterFormMain = new FormHome(studentsList, accountType);
            enterFormMain.Show();
            this.Close();
        }

        protected void btnATasksSchedule_Click(object sender, EventArgs e)
        {
            FormHome mainTaskschuduleAdmin = new FormHome(studentsList, accountType);
            mainTaskschuduleAdmin.Show();
            this.Close();
        }

        private void groceriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTenantsManagement formTenantsManagement = new FormTenantsManagement(studentsList, accountType);
            formTenantsManagement.MdiParent = this;
            formTenantsManagement.ControlBox = false;
            formTenantsManagement.MaximizeBox = false;
            formTenantsManagement.MinimizeBox = false;
            formTenantsManagement.ShowIcon = false;
            formTenantsManagement.Text = "";
            formTenantsManagement.Dock = DockStyle.Fill;
            formTenantsManagement.Show();
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountType = AccountType.NOACCOUNT;
            FormHome formHome = new FormHome(studentsList, accountType);
            formHome.Show();
            this.Close();
        }

        private void complaintsToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void houseRulesToolStripMenuItem_Click_1(object sender, EventArgs e)
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
    }
}
