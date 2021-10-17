using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1
    {
        public string Number { get; }

        public string Name { get; set; }

        public decimal Balance { get; }

        public Class1(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
            Number = "123456789";
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {

        }
    }
}
