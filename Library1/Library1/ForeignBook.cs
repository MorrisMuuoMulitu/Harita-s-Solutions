using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    class ForeignBook : Book
    {
        private string Language;
        private int Level;

        private static int MinPrice = 0;
        private static string[] lvlName = { "Basic level", "Intermediate level", "Advanced level" };
        private static int[] lvlVocab = { 400, 1000, 1500 };

        public ForeignBook(string author, string title, int numberOfPages, int purchasePrice, string language, int level) : 
            base(author, title, numberOfPages, purchasePrice)
        {
            this.Language = language;
            this.Level = level;
        }
        public override string ToString()
        {
            return ("language"+Language+"difficulty"+lvlName+"vocabulary"+lvlVocab);
        }
        public string language
        { get { return language; } }

        public override int SalePrice
        {
            get
            {
                int newPrice = (int)(base.SalePrice * (1 - lvlVocab[Level] / 1000));
                return Math.Max(newPrice, MinPrice);
            }
        }
          
        public static int minPrice
        {
            get { return MinPrice; }
            set { MinPrice = value; }
        }
    }
    }
}
