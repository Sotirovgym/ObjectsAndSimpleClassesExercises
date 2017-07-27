using System;
using System.Collections.Generic;
using System.Linq;

class OptimizedBankingSystem
{
    static void Main()
    {
        var bankAccounts = new List<BankAccount>();

        var input = Console.ReadLine();

        while (input != "end")
        {
            var tokens = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

            var bank = tokens[0];
            var name = tokens[1];
            var balance = decimal.Parse(tokens[2]);

            var newBankAccount = new BankAccount
            {
                Bank = bank,
                Name = name,
                Balance = balance
            };

            bankAccounts.Add(newBankAccount);

            input = Console.ReadLine();
        }

        foreach (var bankAccount in bankAccounts.OrderByDescending(b => b.Balance).ThenBy(b => b.Bank.Length))
        {
            Console.WriteLine($"{bankAccount.Name} -> {bankAccount.Balance} ({bankAccount.Bank})");
        }
    }
}

