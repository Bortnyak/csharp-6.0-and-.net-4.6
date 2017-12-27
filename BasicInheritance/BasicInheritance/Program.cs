using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Basic Inheritance ***** ");

            Car myCar = new Car(80);
            myCar.Speed = 50;
            myCar.DisplayStatus();

            Car mySecondCar = new Car(120);
            mySecondCar.Speed = 121;
            mySecondCar.DisplayStatus();

            MiniVan myMiniVan = new MiniVan();
            myMiniVan.Speed = 10;
            Console.WriteLine("My van is going {0} MPH", myMiniVan.Speed);

            Console.ReadLine();
        }
    }
}
