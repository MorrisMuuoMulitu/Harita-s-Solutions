using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTales
{
    class Witches:Lady
    {
        public static int withchesMultiplier;
        public bool curse;

        // constructor
        public Witches(string name, int magicalPower, int strength, bool curse) : base(name, magicalPower, strength)
        {
            this.curse = curse;
            curse = false;
            if (strength==0)
            {
                Console.WriteLine("she has been improved");
            }
        }

        // methods
        public override int DegreeOfImpact()
        {
            return Strength * withchesMultiplier-1;  
        }
        public override string ToString()
        {
            return base.ToString() + "\nit is a witch" + curse;
        }
    }
}
