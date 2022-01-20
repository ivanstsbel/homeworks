using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class BankAccount
    {
        static int SerialNumber = 0;
        private int accountnumber;
        private double balance;
        private int accounttype;
        public int AccountNumber { get { return accountnumber; } /*set { accountnumber = value; } */}
        public double Balance { get { return balance; } set { balance = value; } }
        public int AccountType { get { return accounttype ; } set { accounttype = value; } }
        public int NumberInc()
        {
            SerialNumber++;
            return SerialNumber;
        }
        public BankAccount()
        {
            this.accountnumber = NumberInc();
        }

        public BankAccount(int accounttype)
        {
            this.accounttype = accounttype;
            this.accountnumber = NumberInc();
        }
        public BankAccount(double balance)
        {
            this.balance = balance;
            this.accountnumber = NumberInc();
        }
        public BankAccount(double balance, int accounttype)
        {
            this.balance = balance;
            this.accounttype = accounttype;
            this.accountnumber = NumberInc();
        }

    }
}
