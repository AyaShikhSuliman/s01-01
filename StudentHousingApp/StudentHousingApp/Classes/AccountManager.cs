using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingApp
{
    public class AccountManager
    {
        private List<Account> tenantList = new List<Account>();
        private List<Account> logins = new List<Account>();
        private string fileName = "AccountList.csv";

        public string FileName => fileName;

        public Account GetLastAccount()
        {
            return this.logins.Last();
        }

        public Account[] GetAllAccounts()
        {
            return this.tenantList.ToArray();
        }

        public Account[] GetStudentAccounts()
        {
            List<Account> accounts = new List<Account>();

            foreach (var account in this.tenantList)
            {
                if (account.AccountType == AccountType.STUDENT)
                {
                    accounts.Add(account);
                }
            }

            return accounts.ToArray();
        }

        public void AddToTenantList(Account account)
        {
            this.tenantList.Add(account);
        }

        public void RemoveFromTenantList(Account account)
        {
            this.tenantList.Remove(account);
        }

        public void AddToCSVFile(Account account)
        {
            string textToAdd = $"{account.StudentID},{account.Username},{account.Password},{account.AccountType}" + Environment.NewLine;

            if (!File.Exists(fileName))
            {
                string csvHeader = "StudentID,Username,Password,Account type" + Environment.NewLine;
                File.WriteAllText(fileName, csvHeader);
            }

            File.AppendAllText(fileName, textToAdd);
        }

        public void RemoveFromCSVFile(Account account)
        {
            string[] csvLines = File.ReadAllLines(fileName);
            string newCsvData = "";
            foreach (string line in csvLines)
            {
                string[] currentLine = line.Split(',');
                if (line == csvLines[0])
                {
                    newCsvData += line + Environment.NewLine;
                }
                else if ((int.Parse(currentLine[0]) != account.StudentID))
                {
                    newCsvData += line + Environment.NewLine;
                }
            }
            File.WriteAllText(fileName, newCsvData);
        }

        public void SetLastLogin(Account account)
        {
            this.logins.Add(account);
        }
    }
}
