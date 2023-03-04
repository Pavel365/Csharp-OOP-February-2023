using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBirthable> society = new List<IBirthable>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];

                if (command == "Citizen")
                {
                    IBirthable citizen 
                        = new Citizen(tokens[3], tokens[1], int.Parse(tokens[2]), tokens[4]);
                    society.Add(citizen);
                }
                else if (command == "Pet")
                {
                    IBirthable pet = new Pet(tokens[1], tokens[2]);
                    society.Add(pet);
                }
            }

            string year = Console.ReadLine();

            foreach (IBirthable birthable in society)
            {
                if (birthable.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(birthable.Birthdate);
                }
            }
        }
    }
}
