using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingApp
{
    public class Announcement
    {
        private string name;
        private string date;
        private string description;
        public Announcement(string Name, string Date, string Description)
        {
            this.name = Name;
            this.date = Date;
            this.description = Description;
        }

        public string DisplayAnnouncement()
        {
            return $"{this.name}: {this.date} - {this.description}";
        }
    }
}
