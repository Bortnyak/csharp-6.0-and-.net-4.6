﻿using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** The Employee Class Hierachy ***** \n");
            //SalesPerson fred = new SalesPerson();
            //fred.Age = 31;
            //fred.Name = "Fred";
            //fred.SalesNumber = 50;

            //Employee emp = new Employee();
            //emp.Name = "Nick";

            Manager chucky = new Manager("Chucky", 50, 92, 10000, "333-23-32", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();

            Console.ReadLine();
        }
    }
}
