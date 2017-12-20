using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");
            //Создать объект счета.
            SavingsAccount s1 = new SavingsAccount(50);

            //Вывести текущую процентую ставку
            Console.WriteLine("Interest Rate is {0}", SavingsAccount.GetInterestRate());

            SavingsAccount.SetInterestRate(0.08);

            //Создать второй объект счета.
            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine("Interest Rate is {0}", SavingsAccount.GetInterestRate());

            //Создать новый объект; это не 'сбросит' процентую ставку.
            SavingsAccount s3 = new SavingsAccount(1000.75);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            Console.ReadLine();
        }
    }
}
