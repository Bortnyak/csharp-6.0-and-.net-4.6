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
        }
    }
}
