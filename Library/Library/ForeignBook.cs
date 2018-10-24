using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ForeignBook:Book
    {
        public int HeadWord { get; set; }
        public string Language { get; }

       

        public ForeignBook(string authour, string title, int numwords, int pages, int purchasePrice, string language) : base(authour, title, numwords, pages, purchasePrice)
        {
            this.Language = language;
        }

        public override string ToString()
        {
            return base.ToString() + "\nLangage: " + Language;
        }



    }
}
