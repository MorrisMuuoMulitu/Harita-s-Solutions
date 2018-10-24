using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberEvaluation
{
    class Program
    {
         static void Main(string[] args)
        { 
            int number;
           // Console.WriteLine("Enter the number");
            Console.Write("Please enter the Number\n");
            number = Convert.ToInt32(Console.ReadLine());
            {
                if (number > 0)
                {
                    Console.WriteLine("The Number is positive.", number);
                    Console.ReadLine();
                }

                else if (number == 0)
                {
                    Console.WriteLine("  The Number entered is zero.", number);
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("The Number is negative.", number);
                    Console.ReadLine();
                }
                Console.ReadLine();
            }
        } 
    }
}
