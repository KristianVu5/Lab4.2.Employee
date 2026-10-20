using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4._2.Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee;
            employee = new Employee("Elena", "Ivanova",34,100);
            Console.WriteLine("\nSalary=" + employee.calculatePay(40) + "\n");
            SalariedEmployee employeesal;
            employeesal = new SalariedEmployee("Bozhidar", "Stoev",49,200);
            Console.WriteLine("\nSalary=" + employeesal.calculatePay(40) + "\n");
            Console.ReadLine();
        }
    }
}
