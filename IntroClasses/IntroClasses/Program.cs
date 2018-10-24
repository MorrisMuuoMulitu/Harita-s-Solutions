using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.name = "Mercedez";
            myCar.model = "A3";
            myCar.year = 2017;
            myCar.colour = "Black";

            Console.WriteLine("Name:{0}\nModel:{1}\nYear:{2}\ncolour:{3}\n",myCar.name,myCar.model,myCar.year,myCar.colour);
            Console.ReadLine();
               
        }

       
    }
}
