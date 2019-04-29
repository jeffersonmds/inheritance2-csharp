using System;
using Inheritance2.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List <Payer> list = new List<Payer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (option == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, expenditures));
                }
                else if (option == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
            }
            Console.WriteLine("\nTAXES PAID:");
            double sum = 0.0;
            foreach(Payer p in list)
            {
                Console.WriteLine(p.Name + ": $ " + p.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
                sum += p.TaxesPaid();
            }
            Console.WriteLine("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
