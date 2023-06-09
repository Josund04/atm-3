﻿// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        var atm = new Atm();
        while (true)
        {
            int option;

            Console.WriteLine();
            Console.WriteLine("Meny:");
            Console.WriteLine("1. Skapa konto");
            Console.WriteLine("2. Insättning");
            Console.WriteLine();
            Console.Write("Var vänlig välj ett alternativ ");

            var input = int.TryParse(Console.ReadLine(), out option);

            Console.WriteLine("-----------------");

            switch (option)
            {
                case 1:
                    atm.CreateAccount();
                    break;
                case 2:
                    atm.Deposit();
                    break;
            }
        }
    }
}
class Account
{
    public int Id { get; set; }
    public string FörstaNamn { get; set; }
    public string Efternamn { get; set; }
    public DateTime Födelsedag { get; set; }
    public string Telefonnummer { get; set; }
    public double Saldo { get; set; }
}
