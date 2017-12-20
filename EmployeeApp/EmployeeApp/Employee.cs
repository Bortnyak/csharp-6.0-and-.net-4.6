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

        //Метод доступа
        public string GetName()
        {
            return empName;
        }

        public int GetID()
        {
            return empID;
        }

        public float GetPay()
        {
            return currPay;
        }

        //Метод изминения
        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                empName = name;
            }
        }

        public void SetID(int id)
        {
            empID = id;
        }

        public void SetPay(float pay)
        {
            currPay = pay;
        }

        //Конструкторы.
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }

        //Методы.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", empName); // имя сотрудника
            Console.WriteLine("ID: {0}", empID); // идентефикационный номер сотрудника
            Console.WriteLine("Pay: {0}", currPay); // текущая выплата
            Console.ReadLine();
        }
    }
}
