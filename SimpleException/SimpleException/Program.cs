﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Simple Exception Example ***** ");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            //Розогнать автомобиль до скорости, превышающей максимальный предел, с целью выдачи исключения.
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n************ Error! ************");
                Console.WriteLine("\nMember name: {0}", e.TargetSite); // имя члена
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType); //клас, определяющий член
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType); //тип члена
                Console.WriteLine("Message: {0}", e.Message); //сообщение
                Console.WriteLine("Source: {0}", e.Source); //источник
                Console.WriteLine("Stack: {0}", e.StackTrace);
            }
            Console.WriteLine("\n************ Out of Exception logic ************");
            Console.ReadLine();
        }
    }
}
