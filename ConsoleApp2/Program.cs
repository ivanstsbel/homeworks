using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount account = new BankAccount();

           
            account.Balance = 80000;
            account.AccountType = 3;
            Console.WriteLine($"Номер счета: {account.AccountNumber} Баланс: {account.Balance} Тип счета: {account.AccountType}");
        }
    }
}
