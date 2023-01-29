using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int value = r.Next(0, 2);//only generate values bt 0-2 means 0,1 ;
            // 0 is for present;
            // 1 is for absent;
            if (value == 0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
        }
    }
}
