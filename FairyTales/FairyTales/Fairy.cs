using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTales
{
    class Fairy:Lady
    {
        public static int fairiesMultiplier;
        public bool bless;
        
        //constructor
        public Fairy(string name, int magicalPower, int strength, bool bless) : base(name, magicalPower, strength)
        {
            this.bless = bless;
            bless = true;
        }
        //method
        public override int DegreeOfImpact()
        {
            return Strength * fairiesMultiplier;
        }
        public override string ToString()
        {
            return base.ToString()+"\nit is a fairy"+bless;
        }
    }
}
