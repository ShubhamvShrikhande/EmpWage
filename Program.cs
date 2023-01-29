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
        public const int noOfWorkingDays = 2;
        public const int maxHrsInMonth = 10;
        static void Main(string[] args)
        {
            int empHr = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < noOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs = totalEmpHrs + empHr;
                Console.WriteLine("Days=" + totalWorkingDays + "Emp Hrs=" + empHr);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total Emp Wage=" + totalEmpWage);


        }
    }
    
}
