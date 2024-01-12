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
    public partial class FormHome : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;

        public FormHome(AccountManager s, AccountType AccountType)
        {
            InitializeComponent();
            studentsList = s;
            accountType = AccountType;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            ClearDates(5, 35);
            SetDates(grocery.GetInterval(), grocery.GetColor());
            SetDates(garbage.GetInterval(), garbage.GetColor());
            SetDates(kitchen.GetInterval(), kitchen.GetColor());
            SetDates(toilet.GetInterval(), toilet.GetColor());
            SetDates(storageSpace.GetInterval(), storageSpace.GetColor());
            SetDates(hallway.GetInterval(), hallway.GetColor());
            ClearDates(0, 5);
        }

        Task grocery = new Task("Grocery", 7, System.Drawing.Color.DarkRed);
        Task garbage = new Task("Garbage", 7, System.Drawing.Color.OrangeRed);
        Task kitchen = new Task("Kitchen", 3, System.Drawing.Color.LightSeaGreen);
        Task toilet = new Task("Toilet", 5, System.Drawing.Color.Purple);
        Task storageSpace = new Task("Storage Space", 14, System.Drawing.Color.FromArgb(64, 64, 64));
        Task hallway = new Task("Hallway", 6, System.Drawing.Color.Olive);

        public void ClearDates(int start, int end)
        {
            string lvName = "lvBox";
            //clear all
            for (int i = start; i < end; i++)
            {
                string lvTestName = (lvName + i.ToString());

                var control = this.Controls.OfType<ListView>().FirstOrDefault(c => c.Name == lvTestName);
                if (control != null)
                {
                    control.Invoke((MethodInvoker)(() => control.Items.Clear()));
                }
            }
        }
        public void SetDates(int interval, System.Drawing.Color color)
        {
            for (int i = 0, j = 0, t = 0; i < 35 && (studentsList.GetStudentAccounts().Count() > 0); i++, t++)
            {
                string lvName = "lvBox";
                if (j == (studentsList.GetStudentAccounts().Count()))
                {
                    j = 0;
                }

                string lvTestName = (lvName + i.ToString());

                ListViewItem nameDisplay = new ListViewItem();
                nameDisplay.ForeColor = color;
                nameDisplay.Text = studentsList.GetStudentAccounts()[j].Username;

                var control = this.Controls.OfType<ListView>().FirstOrDefault(c => c.Name == lvTestName);
                if (control != null && (t % interval == 0))
                {
                    control.Invoke((MethodInvoker)(() => control.Items.Add(nameDisplay)));
                    j++;
                }
            }
        }
        public void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogIn enterlog = new FormLogIn(studentsList, accountType);
            enterlog.Show();
            this.Hide();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (accountType == AccountType.NOACCOUNT)
            {
                btnLogin.Visible = true;
            }
            else if (accountType == AccountType.STUDENT || accountType == AccountType.ADMIN)
            {
                btnLogin.Visible = false;
            }
        }
    }
}
