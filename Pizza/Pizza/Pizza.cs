using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSimple2
{
    class Pizza
    {
        public string Name { get; private set; }
        public int SmallSizePrice { get; set; }
        public int LargeSizePrice { get; set; }

        // constructor
        public Pizza(string name, int smallSizePrice,
            int largeSizePrice)
        {
            this.Name = name;
            this.SmallSizePrice = smallSizePrice;
            this.LargeSizePrice = largeSizePrice;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
