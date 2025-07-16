using System;

class ATM
{
    private decimal balance;

    public ATM(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- ATM Menu ---");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine($"Current Balance: R{balance:F2}");
                    break;
                case "2":
                    Console.Write("Enter deposit amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal deposit) && deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine("Deposit successful.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;
                case "3":
                    Console.Write("Enter withdrawal amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdraw) && withdraw > 0)
                    {
                        if (withdraw <= balance)
                        {
                            balance -= withdraw;
                            Console.WriteLine("Withdrawal successful.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the ATM.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void Main()
    {
        ATM atm = new ATM(1000); // Initial balance R1000
        atm.ShowMenu();
    }
}
