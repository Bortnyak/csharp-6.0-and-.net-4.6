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
            //Разместить в память и сконфигурировать объект Car.
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            //Увеличить скорость автомобиля в несколько раз и вывести новое состояние
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();
        }
    }
}
