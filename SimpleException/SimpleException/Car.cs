using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Car
    {
        //Костанта для представления максимальной скорости.
        public const int maxSpeed = 100;
        
        //Свойства автомобиля.
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        //Не вышел ли автомобил из строя?
        private bool carIsDead;

        //В автомобиле имеется радиоприемник.
        private Radio theMusicBox = new Radio();

        //Констукторы
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            //Делегировать запрос внутреннему объекту.
            theMusicBox.TurnOn(state);
        }

        //Проверить, не перегрелся ли автомобиль.
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order..", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= maxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;

                    //Использовать ключевое слово throw для генерации исключения.
                    throw new Exception(string.Format("{0} has overheated!", PetName));
                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }

    }
}
