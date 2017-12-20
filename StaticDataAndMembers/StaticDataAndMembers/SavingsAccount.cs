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
        private static double currentInterestRate = 0.04;

        //Статическое свойство.
        public static double InterestRate
        {
            get { return currentInterestRate; }
            set { currentInterestRate = value; }
        }

        //Конструктор устанавливает значение статического поля currInterestRete.
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
        
    }
}
