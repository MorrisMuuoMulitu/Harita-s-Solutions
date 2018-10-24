using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmas
{
    class Tree
    { public string Name { get;private set; }
      public int Size { get; set; }
      public string PicName { get; set; }
      public int VoteNumber { get; private set; }

        //constructor
    public Tree (string name, int size, string picname)
        {
            this.Name = name;
            this.Size = size;
            this.PicName = picname;

        }
        public void ModifyVoteNumber()
        {
            VoteNumber++;
        }
        public override string ToString()
        {
            return Name.PadRight(15) + Size.ToString().PadLeft(4) + "meters";
        }
    }
}
