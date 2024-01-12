using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingApp
{
    public class Account
    {
        private string username;
        private string password;
        private int studentID;
        private AccountType accountType;

        private List<Notification> notifications = new List<Notification>();
        private List<Announcement> announcements = new List<Announcement>();
        private List<Complaint> complaints = new List<Complaint>();
        private List<HouseRule> houseRules = new List<HouseRule>();

        public Account() { }

        public Account(int astudentID, string ausername, string apassword, AccountType accountType)
        {
            this.studentID = astudentID;
            this.username = ausername;
            this.password = apassword;
            this.accountType = accountType;
        }

        public string Username => this.username;

        public string Password => this.password;

        public int StudentID => this.studentID;

        public AccountType AccountType
        {
            get => this.accountType;
            set => accountType = value;
        }

        public void AddNotification(Notification notification)
        {
            this.notifications.Add(notification);
        }

        public void RemoveNotification(Notification notification)
        {
            this.notifications.Remove(notification);
        }

        public List<Notification> GetNotifications()
        {
            return this.notifications;
        }

        public void AddAnnouncement(Announcement announcement)
        {
            this.announcements.Add(announcement);
        }
        public void RemoveAnnouncement(Announcement announcement)
        {
            this.announcements.Remove(announcement);
        }
        public List<Announcement> GetAnnouncement()
        {
            return this.announcements;
        }

        public void AddComplaint(Complaint complaint)
        {
            this.complaints.Add(complaint);
        }

        public void RemoveComplaint(Complaint complaint)
        {
            this.complaints.Remove(complaint);
        }

        public List<Complaint> GetComplaints()
        {
            return this.complaints;
        }

        public List<HouseRule> GetHouseRules()
        {
            return this.houseRules.ToList();
        }

        public void RemoveHousRule(HouseRule houseRule)
        {
            this.houseRules.Remove(houseRule);
        }

        public void AddHouseRule(HouseRule houseRule)
        {
            this.houseRules.Add(houseRule);
        }
    }
}
