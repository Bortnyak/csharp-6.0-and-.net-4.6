using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Функциональность на уровне класса
            //Это работает нормально!
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();
            
            //Ошибка, метод SayHello - приватный
            //TimeUtilClass.SayHello();


            Console.ReadLine();
        }
    }
}
