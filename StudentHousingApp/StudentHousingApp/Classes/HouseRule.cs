using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingApp
{
    public class HouseRule
    {
        private string rule;

        public HouseRule(string rule)
        {
            this.rule = rule;
        }

        public string DisplayRule()
        {
            return $"- {rule}.";
        }
    }
}
