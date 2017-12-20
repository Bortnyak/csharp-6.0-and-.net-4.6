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
            Employee vova = new Employee(1, "Volodja", 21, 28000);
            vova.DisplayStatus();

            Employee dejv = new Employee(1, "Dejv", 32, 23000);
            dejv.DisplayStatus();

            Employee marv = new Employee();
            marv.ID = 2;
            marv.Name = "Marvin";
            marv.Age = 22;
            marv.Pay = 20000;
            marv.DisplayStatus();

        
            Employee harry = new Employee();
            harry.ID = 3;
            harry.Name = "Harry";
            harry.Age = 23;
            harry.Pay = 19011;
            harry.DisplayStatus();
        }
    }
}
