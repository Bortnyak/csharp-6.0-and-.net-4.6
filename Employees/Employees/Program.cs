using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double cost = chucky.GetBenefitCoast();
            Console.ReadLine();
        }
    }
}
