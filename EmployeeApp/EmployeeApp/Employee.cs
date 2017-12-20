using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        //Поля данных.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private int empSSN;

       //Свойства
       public string Name
        {
            get { return empName; }
            set {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                } else
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public int SocialSecurityNumber
        {
            get { return empSSN; }
        }

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

        //Методы.
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", empName); // имя сотрудника
            Console.WriteLine("ID: {0}", empID); // идентефикационный номер сотрудника
            Console.WriteLine("Age: {0}", empAge); // возраст сотрудника
            Console.WriteLine("Pay: {0}", currPay); // текущая выплата
            Console.WriteLine("SSN: {0}", empSSN); // текущий социальный номер страхования

            Console.ReadLine();
        }
    }
}
