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
    public partial class FormComplaints : Form
    {
        private AccountManager studentsList;
        private AccountType accountType;

        public FormComplaints(AccountManager s, AccountType accountType)
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
            string description = txbxMessage.Text;

            if(description != String.Empty)
            {
                string senderName = studentsList.GetLastAccount().Username;
                Complaint complaint = new Complaint(senderName, description);

                if (studentsList.GetLastAccount().AccountType == AccountType.ADMIN)
                {
                    foreach (var item in studentsList.GetStudentAccounts())
                    {
                        Notification notification = new Notification("Complaint");
                        complaint.AddReference(0);
                        item.AddNotification(notification);
                        item.AddComplaint(complaint);
                    }
                    lbComplaints.Items.Add(complaint.DisplayComplaint());
                }
                else if(studentsList.GetLastAccount().AccountType == AccountType.STUDENT)
                {
                    foreach (var item in studentsList.GetAllAccounts())
                    {
                        if(item.AccountType == AccountType.ADMIN)
                        {
                            Notification notification = new Notification("Complaint");
                            complaint.AddReference(studentsList.GetLastAccount().StudentID);
                            item.AddNotification(notification);
                            item.AddComplaint(complaint);
                        }
                    }
                    lbComplaints.Items.Add(complaint.DisplayComplaint());
                }
                MessageBox.Show("Complaint sent!");
                txbxMessage.Text = "";
            }
            else
            {
                MessageBox.Show("Text box cannot be empty!");
            }
        }


        private void btnDeleteNotification_Click(object sender, EventArgs e)
        {
            foreach (var item in studentsList.GetAllAccounts())
            {
                if (item.StudentID == studentsList.GetLastAccount().StudentID)
                {
                    foreach (var complaint in item.GetComplaints())
                    {
                        if (complaint.DisplayComplaint() == lbComplaints.SelectedItem.ToString())
                        {
                            item.RemoveComplaint(complaint);
                            break;
                        }
                    }
                }
            }
            lbComplaints.Items.Remove(lbComplaints.SelectedItem);
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            string replyName = studentsList.GetLastAccount().Username;
            string replyMessage = txbxMessage.Text;
            Account currentAccount = studentsList.GetLastAccount();
            Complaint currentComplaint = null;
            int complaintID = 0;

            foreach (var complaint in currentAccount.GetComplaints())
            {
                if (complaint.DisplayComplaint() == lbComplaints.SelectedItem.ToString())
                {
                    complaint.AddReply(replyName, replyMessage);
                    complaintID = complaint.Reference;
                    currentComplaint = complaint;
                }
            }

            foreach(var student in studentsList.GetAllAccounts())
            {
                if(student.StudentID == complaintID)
                {
                    currentComplaint.AddReference(currentAccount.StudentID);
                    student.AddComplaint(currentComplaint);
                    break;
                }
            }

            txbxMessage.Text = String.Empty;
            lbComplaints.Items.Remove(lbComplaints.SelectedItem);
            MessageBox.Show("Reply sent!");
            currentAccount.RemoveComplaint(currentComplaint);
        }

        private void FormComplaints_Load(object sender, EventArgs e)
        {
            lbComplaints.Items.Clear();
            foreach (var item in studentsList.GetAllAccounts())
            {
                if (item.StudentID == studentsList.GetLastAccount().StudentID)
                {
                    foreach (var complaint in item.GetComplaints())
                    {
                        lbComplaints.Items.Add(complaint.DisplayComplaint());
                    }
                }
            }
        }
    }
}
