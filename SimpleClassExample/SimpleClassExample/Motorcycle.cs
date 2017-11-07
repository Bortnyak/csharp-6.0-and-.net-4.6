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
        public string driverName;
        
        //Переопределяю стандарный конструктор
        public Motorcycle() { }

        //Специалный конструктор
        public Motorcycle(int intensity)
        {

            SetIntensity(intensity);
        }

        public Motorcycle(int intensity, string name)
        {
            SetIntensity(intensity);
            driverName = name;
        }

        public void SetDriverName(string name)
        {
            driverName = name;
        }

        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeeee Haaaaaeeewww!");
            }
        }
    }
}
