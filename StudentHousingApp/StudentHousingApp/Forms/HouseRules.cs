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
    public partial class FormHouseRules : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;

        public FormHouseRules(AccountManager s, AccountType accountType)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string houseRuledescription = tbHouseRules.Text;

            foreach (var item in studentsList.GetStudentAccounts())
            {                
                HouseRule houseRule = new HouseRule(houseRuledescription);
                item.AddHouseRule(houseRule);
                Notification notification = new Notification("House Rule");
                item.AddNotification(notification);
            }

            lbHouseRules.Items.Add($"- {houseRuledescription}.");
            MessageBox.Show("Your house rule has been added!");
            tbHouseRules.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in studentsList.GetAllAccounts())
            {
                if (item.StudentID == studentsList.GetLastAccount().StudentID)
                {
                    foreach (var rule in item.GetHouseRules())
                    {
                        if (rule.DisplayRule() == lbHouseRules.SelectedItem.ToString())
                        {
                            item.RemoveHousRule(rule);
                            break;
                        }
                    }
                }
            }
            lbHouseRules.Items.Remove(lbHouseRules.SelectedItem);
        }

        private void FormHouseRules_Load(object sender, EventArgs e)
        {
            lbHouseRules.Items.Clear();
            lbHouseRules.Items.Add("- No smoking allowed in the building.");
            lbHouseRules.Items.Add("- No parties during the week.");
            lbHouseRules.Items.Add("- Everyone should follow the calendar.");

            foreach (var item in studentsList.GetAllAccounts())
            {
                if (item.StudentID == studentsList.GetLastAccount().StudentID)
                {
                    foreach (var rule in item.GetHouseRules())
                    {  
                        lbHouseRules.Items.Add(rule.DisplayRule());
                    }
                }
            }

            if (accountType == AccountType.ADMIN)
            {
                tbHouseRules.Visible = true;
                btnDelete.Visible = true;
                btnAdd.Visible = true;
            }

            if (accountType == AccountType.NOACCOUNT)
            {
                tbHouseRules.Visible = false;
                btnDelete.Visible = false;
                btnAdd.Visible = false;
            }
        }
    }
}
