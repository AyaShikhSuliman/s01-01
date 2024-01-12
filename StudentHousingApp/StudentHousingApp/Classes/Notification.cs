using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingApp
{
   public class Notification
    {
        private string description;
        private double price;
        private string category;
        private List<Grocery> groceryList = new List<Grocery>();
        private Account senderAccount;

        public Notification(string Description, double Price, string Category)
        {
            this.description = Description;
            this.price = Price;
            this.category = Category;
        }
        public Notification(string Category)
        {
            this.category = Category;
        }
        public string Description => this.description;
        public double Price => this.price;

        public string DisplayGroceryNotification()
        {
            if(this.Description == null)
            {
                return string.Empty;
            }
            else
            {
                string groceries = "";
                foreach (Grocery grocery in this.groceryList)
                {
                    if (grocery == this.groceryList.Last())
                    {
                        groceries += $"{grocery.ProductName} €{grocery.Price}";
                    }
                    else
                    {
                        groceries += $"{grocery.ProductName} €{grocery.Price}, ";
                    }
                }
                return $"Amount to pay to {this.senderAccount.Username} = €{this.price} - {this.description} ({groceries})";
            }
        }
        public string DisplayNotification()
        {
            return $"You have a new {this.category}!";
        }

        public void AddToGroceryList(List<Grocery> groceries)
        {
            foreach(Grocery grocery in groceries)
            {
                this.groceryList.Add(grocery);
            }
        }

        public void AddSender(Account account)
        {
            this.senderAccount = account;
        }
    }
}
