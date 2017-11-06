using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Passing Person object by value ****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:");//Перед вызовом
            fred.Display();

            SendPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:");//После вызова
            fred.Display();
            Console.ReadLine();
        }
        static void SendPersonByValue(Person p)
        {
            p.personAge = 99;
            p = new Person("Niki", 99);
        }
    }

    class Person
    {
        public string personName;
        public int personAge;

        //Конструкторы
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }
        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
        
    }
}
