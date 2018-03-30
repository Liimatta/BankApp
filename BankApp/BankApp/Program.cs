using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Jpankki");
            bank.CreateAccount();
            Console.ReadKey();
        }
    }
}
