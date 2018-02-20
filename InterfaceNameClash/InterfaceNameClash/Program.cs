using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Octagon oct = new Octagon();
            //Для доступа к членам Draw() должно использоваться приведение.
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            //Сокращенная форма, если переменная интерфейса не нужна.
            ((IDrawToMemory)oct).Draw();
        }
    }
}
