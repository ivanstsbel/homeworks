using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount account = new BankAccount();
            BankAccount account2 = new BankAccount();


            account.Balance = 80000;
            account.AccountType = 3;
            Console.WriteLine("Задание 1");
            Console.WriteLine($"Номер счета: {account.AccountNumber} Баланс: {account.Balance} Тип счета: {account.AccountType}");

            account2.Balance = 50000;
            account2.AccountType = 3;
            Console.WriteLine($"Номер счета: {account2.AccountNumber} Баланс: {account2.Balance} Тип счета: {account2.AccountType}");            account2.transfer(account, 40000);
            Console.WriteLine($"Номер счета: {account.AccountNumber} Баланс: {account.Balance} Тип счета: {account.AccountType}");
            Console.WriteLine($"Номер счета: {account2.AccountNumber} Баланс: {account2.Balance} Тип счета: {account2.AccountType}");
            Console.WriteLine("Задание 2 \nВведите строку:");
            string str = Console.ReadLine();
            Console.WriteLine($"Результат :{revers.reverse(str)}"); 
        }
    }
}
