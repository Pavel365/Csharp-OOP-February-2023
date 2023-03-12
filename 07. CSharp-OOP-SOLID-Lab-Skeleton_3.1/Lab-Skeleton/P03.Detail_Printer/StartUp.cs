using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class StartUp
    {
        static void Main()
        {
            Employee employee = new Employee("Employee");
            Manager manager = new Manager("Manager", new[] { "Doc 1", "Doc 2", "Doc 3" });
            DetailsPrinter detailsPrinter =
                new DetailsPrinter(new List<Employee>(new[] { employee, manager }));
            Console.WriteLine(detailsPrinter.PrintDetails());
        }
    }
}
