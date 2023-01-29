using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    internal class Program
    {
         public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHr = 20;
        static void Main(string[] args)
        {
            int empHr = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case isPartTime:
                    empHr = 4;
                    break;
                case isFullTime:
                    empHr = 8;
                    break;
                default:
                    empHr = 0;
                    break;
            }
            empWage = empHr * empRatePerHr;

            Console.WriteLine("EmpWage=" + empWage);
        }
    }
    
}
