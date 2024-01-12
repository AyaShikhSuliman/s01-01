using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingApp
{
    public class Task
    {
        private string name;
        private int interval;
        private System.Drawing.Color color;

        public Task(string tname, int tinterval, System.Drawing.Color tcolor)
        {
            this.name = tname;
            this.interval = tinterval;
            this.color = tcolor;
        }
        public int GetInterval()    
        {
            return this.interval;
        }
        public System.Drawing.Color GetColor()
        {
            return this.color;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
