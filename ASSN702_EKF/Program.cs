using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSN701_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double x, sqrt;
            string xstring;


            //User Input
            Console.WriteLine("Please input the number that you would like to find the reciprocal of the square root:");
            xstring = Console.ReadLine();
            x = Convert.ToDouble(xstring);
            
            //If statement        
            if (x > 0)
            {
                sqrt = 1/Math.Sqrt(x);
                Console.WriteLine("The reciprocal of the square root is: {0}", sqrt);
                Console.ReadLine();
            }
            else if (x == 0)
            {
                Console.WriteLine("Error: Division by zero");
                Console.ReadLine();
            }
            else if (x < 0)
            {
                Console.WriteLine("Error: Square root of a negative number");
                Console.ReadLine();
            }//end if


        }//end main
    }//end class
}//end program
