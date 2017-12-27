using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //Поля данных.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private int empSSN;

        //Конструкторы.
        public Employee() { }

        public Employee(int id, string name, float pay)
        {
            empID = id;
            empName = name;
            currPay = pay;
            Random rnd1 = new Random();
            empSSN = rnd1.Next(1, 20);
        }

        public Employee(int id, string name, int age, float pay)
        {
            empID = id;
            empName = name;
            empAge = age;
            currPay = pay;
            Random rnd = new Random();
            empSSN = rnd.Next(1, 20);
        }
    }


}
