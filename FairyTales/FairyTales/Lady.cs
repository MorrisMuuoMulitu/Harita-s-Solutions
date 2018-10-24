using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTales
{
     class Lady
    {
        // properties on which the ladies are described
        public string Name { get; set; }
        public int MagicalPower { get; set; }
        public int Strength { get; set; }

        // the constructor

        public Lady(string name,int magicalPower,int strength)
        {
            this.Name = name;
            this.MagicalPower = magicalPower;
            this.Strength = strength;
        }
        // methods are used to do mathematical operations
        public virtual int DegreeOfImpact()
        {
            //wizardry += Strength;
            return Strength;
        }
        public bool Bless()
        {
            return true;
        }
        public bool Curse()
        {
            return false;
        }
        public override string ToString()
        {
            return ("\nThe name of the lady" + Name + "\nThe degree of magical power" + MagicalPower + "\nits strength" + Strength);
        }

    }
}
