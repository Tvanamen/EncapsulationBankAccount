using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Hello please enter amount you will be depositing today!");
            var cashIn = double.Parse(Console.ReadLine());
          //while (cashIn != double)
          //{
          //    Console.WriteLine("Please enter valid deposit");
          //}
            account.Deposit(cashIn);
            Console.WriteLine($"Thank you for your deposit your balance is now {account.GetBalance()}");




        }
    }
}
