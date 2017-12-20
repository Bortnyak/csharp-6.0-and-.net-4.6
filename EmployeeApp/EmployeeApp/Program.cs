using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Volodja", 1, 15000);
            emp.DisplayStatus();

            Employee marv = new Employee();
            marv.SetName("Marvin");
            marv.SetID(2);
            marv.SetPay(3200);
            marv.DisplayStatus();

            Employee harry = new Employee();
            harry.SetName("Vingardium laviossa");


        }
    }
}
