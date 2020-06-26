using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LearningCSharp
{
    public abstract class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }

        public abstract string GetInfo();
    }

    public class Employee : Person
    {
        public decimal Salary { get; private set; } = 50000;

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is an employee with a salary of {Salary:c}";
        }

        public void GiveRaise(decimal amount)
        {
            Salary += amount;
        }
    }

    public class Retiree : Person
    {
        public decimal Pension { get; private set; } = 38000;

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} is an retiree with a pention of {Pension:c}";
        }
    }
}
