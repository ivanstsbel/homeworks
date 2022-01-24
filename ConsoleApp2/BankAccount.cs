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
        public int AccountType { get { return accounttype; } set { accounttype = value; } }
        public int NumberInc()
        {
            SerialNumber++;
            return SerialNumber;
        }
        public void transfer (BankAccount acc, int sum)
        {
             if(acc.Balance>=sum)
            {
                this.Balance += sum;
                acc.Balance -= sum;
                Console.WriteLine("Перевод средств выполнен!");
            }
            if (acc.Balance < sum)
            {
                Console.WriteLine("Недостаточно средств!");
            }
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
