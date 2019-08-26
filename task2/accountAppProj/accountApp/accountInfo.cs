using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountAppProj
{

    class AccountInfo
    {
        public string firstName;

        public string lastName;

        public int idNumber;

        public int balance = 0;

        public AccountInfo(string firstName, string lastName, int idNumber)
        {
            this.updateCredentials(firstName, lastName, idNumber);
        }

        public void updateCredentials(string firstName, string lastName, int idNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = idNumber;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public int getIdNumber()
        {
            return this.idNumber;
        }

        public int getBalance()
        {
            return this.balance;
        }

        public void withdrawFromBalance(int amount)
        {
            if (this.balance >= amount)
            {
                this.balance = this.balance - amount;
            }
        }

        public void addToBalance(int amount)
        {
            this.balance = this.balance + amount;
        }
    }
}