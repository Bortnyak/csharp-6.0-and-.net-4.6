﻿using System;

namespace Employees
{
    abstract partial class Employee
    {
        // Field data.
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN = "";
        protected BenefitPackage empBenefits = new BenefitPackage();

        #region Ctors
        // Note use of constructor chaining.
        public Employee() { }
        public Employee(string name, int id, float pay)
          : this(name, 0, id, pay)
        { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
        public Employee(string name, int age, int id, float pay, string ssn)
            :this (name, age, id, pay)
        {
            empSSN = ssn;
        }
        #endregion

        #region Properties 
        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name length exceeds 15 characters");
                else
                    empName = value;
            }
        }

        // We could add additional business rules to the sets of these properties,
        // however there is no need to do so for this example.
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
        #endregion
    }
}