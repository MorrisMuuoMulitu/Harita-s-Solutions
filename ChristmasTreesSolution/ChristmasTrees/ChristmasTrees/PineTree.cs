using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTrees {
    public class PineTree {
        public string PineTypeName { get; private set; }
        public int Height { get; set; }
        public string PicName { get; set; }
        public int VoteNumber { get; private set; }

        // constructor
        public PineTree(string typename, int height, string pictureName) {
            this.PineTypeName = typename;
            this.Height = height;
            this.PicName = pictureName;
        }

        public void ModifyVoteNumber() {
            VoteNumber++;
        }

        public override string ToString()
        {
            return PineTypeName.PadRight(16) + 
                Height.ToString().PadLeft(4) +
                " meters";
        }
    }
}
