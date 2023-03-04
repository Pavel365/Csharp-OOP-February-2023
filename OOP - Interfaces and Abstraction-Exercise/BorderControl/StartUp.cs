using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IIdentifiable> society = new List<IIdentifiable>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (tokens.Length == 3)
                {
                    IIdentifiable citizen = new Citizen(tokens[2], tokens[0], int.Parse(tokens[1]));
                    society.Add(citizen);
                }
                else
                {
                    IIdentifiable robot = new Robot(tokens[1], tokens[0]);
                    society.Add(robot);
                }
            }

            string invalidIdSuffix = Console.ReadLine();

            foreach (IIdentifiable identifiable in society)
            {
                if (identifiable.Id.EndsWith(invalidIdSuffix))
                {
                    Console.WriteLine(identifiable.Id);
                }
            }
        }
    }
}
