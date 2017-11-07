using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Fun with Class Types ***** ");
            
            //Вызов стандартного конструктора
            Car chuck = new Car();
            //Печать состояния
            chuck.PrintState();
            //Разместить в память и сконфигурировать объект Car.
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            //Создается объект Car по имени Mary, со скоростью 0 миль в час.
            Car mary = new Car("Mary");
            mary.PrintState();

            //Создается объект Car по имени Daisy, со скоростью 75 миль в час.
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            //Создается объект Motorcycle с мотоциклистом по имени Tiny
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name);
            

            //Увеличить скорость автомобиля в несколько раз и вывести новое состояние
            //for (int i = 0; i <= 10; i++)
            //{
            //    myCar.SpeedUp(5);
            //    myCar.PrintState();
            //}
            Console.ReadLine();
        }
    }
}
