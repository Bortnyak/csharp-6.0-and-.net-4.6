using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Fun with Automatic Properties  *****\n");
            Car macQuin = new Car();
            macQuin.PetName = "Lightning";
            macQuin.Speed = 89;
            macQuin.Color = "Red";

            macQuin.DisplayStatus();

            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStatus();

            Garage g = new Garage();
            g.MyAuto = c;

            Console.WriteLine("Numbers of Cars in garage: {0}", g.NumbersOfCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);


            //Ошибка времени выполнения! Поддерживающее поле в даный момент равно null!
            //Console.WriteLine(g.MyAuto.PetName);
            Console.ReadLine();
        }
    }
}
