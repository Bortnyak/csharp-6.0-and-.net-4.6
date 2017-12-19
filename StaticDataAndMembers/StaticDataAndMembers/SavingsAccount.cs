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
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        //Статический элемент данных.
        public static double currentInterestRate = 0.04;
    }
}
