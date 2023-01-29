using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1;
            int isFullTime = 2;
            int empRatePerHr = 20;
            int empHr = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == isPartTime)
            {
                empHr = 4;
            }
            else if (empCheck == isFullTime)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            empWage = empHr * empRatePerHr;
            Console.WriteLine("EmpWage=" + empWage);
        }
    }
    
}
