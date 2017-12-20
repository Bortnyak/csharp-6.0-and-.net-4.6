using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double currBalance;

        //Статический элемент данных.
        public static double currentInterestRate = 0.04;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        //Статические члены для установки/получения процентной ставки
        public static void SetInterestRate(double newRate)
        {
            currentInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currentInterestRate;
        }
        
    }
}
