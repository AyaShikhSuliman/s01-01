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
    public partial class FormGrocery : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;

        public FormGrocery(AccountManager s, AccountType accountType)
        {
            InitializeComponent();
            studentsList = s;
            this.accountType = accountType;
        }


        List<Grocery> grocery = new List<Grocery>();
        List<double> ListPrice = new List<double>();

        private void btnAddToListBox_Click(object sender, EventArgs e)
        {
            if(tbPrice.Text == "" || tbProductName.Text == "")
            {
                MessageBox.Show("Product name or price cannot be empty!");
            }
            else
            {
                double price = Convert.ToDouble(tbPrice.Text);
                Grocery grocery1 = new Grocery(tbProductName.Text, price);

                lbInfo.Items.Add(grocery1.ProductName + " " + grocery1.Price);
                grocery.Add(grocery1);
                ListPrice.Add(grocery1.Price);

                double totalPrice = ListPrice.Sum();
                lblTotalPrice.Text = Convert.ToString(totalPrice);

                double total = Convert.ToDouble(lblTotalPrice.Text);
                double pricePerPerson = Math.Round(total / studentsList.GetStudentAccounts().Count(), 2);
                lblPricePerTenant.Text = Convert.ToString(pricePerPerson);

                tbPrice.Text = "";
                tbProductName.Text = "";
            }
        }

        private void btnRequestMoney_Click(object sender, EventArgs e)
        {
            if(grocery.Count < 1)
            {
                MessageBox.Show("Please add groceries before submitting!");
            }
            else
            {
                foreach (var item in studentsList.GetAllAccounts())
                {
                    if (item.StudentID != studentsList.GetLastAccount().StudentID)
                    {
                        double pricePerPerson = Convert.ToDouble(lblPricePerTenant.Text);
                        Notification notification = new Notification(tbDescription.Text, pricePerPerson, "Grocery");
                        notification.AddToGroceryList(grocery);
                        notification.AddSender(studentsList.GetLastAccount());
                        item.AddNotification(notification);
                    }
                }

                tbPrice.Text = "";
                lblPricePerTenant.Text = "";
                tbDescription.Text = "";
                tbProductName.Text = "";
                lblTotalPrice.Text = "";
                lbInfo.Items.Clear();
                ListPrice.Clear();
                grocery.Clear();
                MessageBox.Show("Request Sent");
            }
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
    }
}
