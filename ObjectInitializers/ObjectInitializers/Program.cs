using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Fun with Object Init Syntax ***** ");
            
            //Создать объект Point, устанавливая каждое значение вручную.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DispalyStatus();

            //Создать объект Point постредствам специального конструктора.
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DispalyStatus();

            //Создать объект Point, используя синтаксис инициализации объектов.
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DispalyStatus();

            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };

            myRect.DisplayStatus();
            Console.ReadLine();
        }
    }
}
