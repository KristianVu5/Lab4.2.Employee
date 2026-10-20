using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4._2.Employee
{
    internal class SalariedEmployee : Employee
    {
        public SalariedEmployee(string firstName, string lastName, int age, double payrate) : base(firstName, lastName, age, payrate)
        {
        }
        public override double calculatePay(int hoursWorked)
        {
            Console.WriteLine("\nThis is the override method for calculating salary!");
            Console.WriteLine("{0} {1},{2}", firstName, lastName, age);
            payrate = payrate * (double)hoursWorked * 1.2;
            return payrate;
        }
    }
}
