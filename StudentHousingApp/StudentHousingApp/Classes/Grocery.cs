using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingApp
{
    public class Grocery
    {
        private string productName;
        private double price;

        public Grocery(string aProductName,double aPrice)
        {
            this.productName = aProductName;
            this.price = aPrice;
        }

        public string ProductName => this.productName;
        public double Price => this.price;
    }
}
