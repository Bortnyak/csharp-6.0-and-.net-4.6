﻿using System;

namespace Employees
{
    abstract partial class Employee
    {

        #region Class methods 
        public virtual void GiveBonus(float amount)
        { Pay += amount; }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }
        #endregion

        #region Traditional Get / Set method
        // Accessor (get method)
        public string GetName()
        {
            return empName;
        }

        // Mutator (set method)
        public void SetName(string name)
        {
            // Do a check on incoming value
            // before making assignment.
            if (name.Length > 15)
                Console.WriteLine("Error! Name must be less than 15 characters!");
            else
                empName = name;
        }
        public double GetBenefitCoast()
        {
            return empBenefits.ComputePayDeduction();
        }
        #endregion
    }
}