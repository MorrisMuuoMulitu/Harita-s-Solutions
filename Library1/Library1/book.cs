using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    class Book
    {
        private string Author, Title;
        private int NumberOfPages;
        private int PurchasePrice;

        private static double VatRate = 0.27;

        public Book(string author, string title, int numberOfPages, int purchasePrice)
        {
            this.Author = author;
            this.Title = title;
            this.NumberOfPages = numberOfPages;
            this.PurchasePrice = purchasePrice;
        }


        public override string ToString()
        {
            return ("author" + Author + "\ntitle" + Title + "\nnumber of pages" + NumberOfPages + "\nsale price" + SalePrice);

        }
        public string title
        {
            get { return title; }
        }
        public string author
        {
            get { return author; }
        }
        public int numberOfPages
        {
            get { return numberOfPages; }
        }
        private int Tax
        {
            get
            {
                { return (int)(PurchasePrice * VatRate); }
            }
        }
       
        public virtual int SalePrice
        {
            get
            {
                { return (PurchasePrice * Tax); }
            }
        }

        public static double vatRate
        {
            get { return VatRate; }
            set { VatRate = value; }
        }
    } 
}
