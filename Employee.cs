using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4._2.Employee
{
    class Employee
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        protected double payrate;

        public Employee(string firstName, string lastName, int age, double payrate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.payrate = payrate;
        }

        public override string ToString()
        {
            return "Name: " + firstName + " " + lastName + "\tAge: " + age;
        }

        public virtual double calculatePay(int hoursWorked)
        {
            Console.WriteLine("\nThis is the base class method for calculating salary!");
            Console.WriteLine(this.ToString());
            payrate = payrate * (double)hoursWorked;
            return payrate;
        }




    }
}
