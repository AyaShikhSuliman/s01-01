using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingApp
{
    public class Complaint
    {
        private string name;
        private string description;
        private string reply;
        private int reference;

        public Complaint(string Name, string Description)
        {
            this.name = Name;
            this.description = Description;
        }

        public int Reference => this.reference;

        public void AddReference(int id)
        {
            this.reference = id;
        }

        public void AddReply(string name, string Reply)
        {
            this.reply += $" {name} replied: {Reply}";
        }

        public string DisplayComplaint()
        {
            return $"{this.name}: {this.description} {this.reply}";
        }
    }
}
