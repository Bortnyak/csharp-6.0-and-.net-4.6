using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeeee Haaaaaeeewww!");
            }
        }
        //Переопределяю стандарный конструктор
        public Motorcycle() { }

        //Специалный конструктор
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
        public void SetDriverName(string name)
        {
            this.name = name;
        }
    }
}
