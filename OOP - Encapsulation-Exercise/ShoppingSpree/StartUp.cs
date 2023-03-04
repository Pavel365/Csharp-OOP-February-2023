using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                string[] nameMoneyPairs =
                    Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var nameMoneyPair in nameMoneyPairs)
                {
                    string[] nomeMoney = nameMoneyPair
                        .Split("=", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    Person person = new Person(nomeMoney[0], decimal.Parse(nomeMoney[1]));

                    people.Add(person);
                }

                string[] productCostPairs =
                    Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var productCostPair in productCostPairs)
                {
                    string[] productCost = productCostPair
                        .Split("=", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    Product product = new Product(productCost[0], decimal.Parse(productCost[1]));

                    products.Add(product);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

                return;
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] personProduct = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string personName = personProduct[0];
                string productName = personProduct[1];

                Person person = people.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                if (person is not null && product is not null)
                {
                    Console.WriteLine(person.Add(product));
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
