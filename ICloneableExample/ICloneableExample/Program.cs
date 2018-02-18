using System;

namespace ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Interface *****\n");

            //Все эти классы поддерживают интерфейс ICloneable.
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();

            //Следовательно, все они могут буть переданы методу, принимающему параметр типа ICloneable.
            CloneMe(myStr);

            ICloneable myObj = "123";
            object myObjClone = myObj.Clone();
            Console.WriteLine("myObj is {0},\n myObjClone is {1}", myObj, myObjClone);
        }
        private static void CloneMe(ICloneable c)
        {
            // Клонировать то, что получено, и вывести его имя.
            object theClone = c.Clone();
            Console.WriteLine("You clone is a: {0}", theClone.GetType().Name);
        }
    }
}
