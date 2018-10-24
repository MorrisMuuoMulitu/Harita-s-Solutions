using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {

        public string Author { get; private set; }
        public string Name { get; private set; }
        public int NumWords { get; private set; }
        public int Pages { get; private set; }
        public int PurchasePrice { get; private set; }
        public static double VatRate { get; set; }
        
        //private int Tax;
        //private int SellingPrice;

        //private static double VatRate = 0.27;

        //constuctor
        public Book(string authour, string title, int numwords, int pages, int purchasePrice)
        {
            this.Author = authour;
            this.Name = title;
            this.NumWords = numwords;
            this.Pages = pages;
            this.PurchasePrice = purchasePrice;

        }
        public override string ToString()
        {
            //return ("Book title" + Title + "\t Author" + Author + "\t number of pages" + Pages +
            //        "\t the selling price" + SellingPrice);

            return String.Format("Book title: {0}\nAuthor: {1}\nNumber of Pages: {2}\nNumber of Wors: {3}\nPice: {4}\nTax: {5}\nSelling price: {6}\n", Name, Author, NumWords, Pages, 
                PurchasePrice, Tax(), SellingPrice());

        }

        public double Tax()
        {
            return PurchasePrice * VatRate;
        }
       
        public double SellingPrice()
        {
            return PurchasePrice + Tax();
        }

        

    }
}
