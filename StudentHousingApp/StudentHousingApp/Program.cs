using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AccountManager globalList = new AccountManager();
            AccountType accountType = AccountType.NOACCOUNT;  
            
            string[] csvData = File.ReadAllLines(globalList.FileName);
            foreach (string line in csvData.Skip(1))
            {
                string[] lineData = line.Split(',');
                Account account = new Account(int.Parse(lineData[0]), lineData[1], lineData[2], (AccountType)Enum.Parse(typeof(AccountType), lineData[3]));
                globalList.AddToTenantList(account);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome(globalList, accountType));
        }
    }
}
