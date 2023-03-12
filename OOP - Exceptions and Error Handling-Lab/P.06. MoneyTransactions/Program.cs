using System;
using System.Collections.Generic;
using System.Linq;

namespace P._06._MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> bankAccounts = new List<Account>();
            string[] input = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string item in input)
            {
                string[] info = item
                    .Split("-")
                    .ToArray();

                Account newAccount = new Account(info[0], decimal.Parse(info[1]));
                bankAccounts.Add(newAccount);
            }

            string command;
            while ((command = Console.ReadLine())!= "End")
            {
                try
                {
                    VerifyCommand(command);
                    PerformCommand(command, bankAccounts);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }

        private static void PerformCommand(string command, List<Account> bankAccounts)
        {
            string[] tokens = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string accountID = tokens[1];
            decimal money = decimal.Parse(tokens[2]);

            VerifyAccountExists(accountID, bankAccounts);

            Account account = bankAccounts.FirstOrDefault(x => x.Id == accountID);

            if (tokens[0] == "Withdraw")
            {
                account.Withdraw(money);
                Console.WriteLine($"Account {account.Id} has new balance: {account.Balance:f2}");
            }
            else
            {
                account.Deposit(money);
                Console.WriteLine($"Account {account.Id} has new balance: {account.Balance:f2}");
            }
        }

        private static void VerifyAccountExists(string accountID, List<Account> bankAccounts)
        {

            if (bankAccounts.FirstOrDefault(x => x.Id == accountID) == null)
            {
                throw new Exception("Invalid account!");
            }
        }

        private static void VerifyCommand(string command)
        {
            string token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];

            if (!(token == "Withdraw" || token == "Deposit")) 
            { 
                throw new Exception("Invalid command!");
            }

        }
    }

    class Account
    {
        public Account(string id, decimal balance)
        {
            Id = id;
            Balance = balance;
        }

        public decimal Balance { get; private set; }
        public string Id { get; private set; }


        public void Deposit(decimal money) => Balance += money;
        public void Withdraw(decimal money)
        {
            if (money > Balance)
            {
                throw new Exception("Insufficient balance!");
            }
            else
            {
                Balance -= money;
            }
        }

    }
}
