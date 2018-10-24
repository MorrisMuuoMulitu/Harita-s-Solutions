using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO

namespace FactorialCalculation
{
    class Program
    {
        //private static string y;

        static void Main(string[] args)
        {
            int Fact = 1, Num;
            //string Answer;
            Console.Write("Please enter the number \n");
            Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                Fact = Fact * i;
            }
            Console.WriteLine("The factorial of the given number is\n: " + Fact);
            //Console.ReadLine();

            Console.WriteLine("Do you want to continue\n");
      
            char Answer='y';
            Console.Read();
            while (Answer=='y')
            {
                Console.Write("Please enter the number \n");  
                Num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= Num; i++)
                {
                    Fact = Fact * i;
                }
                Console.WriteLine("The factorial of the given number is\n: " + Fact);
                Console.ReadLine();
            }
        }
    }
}
