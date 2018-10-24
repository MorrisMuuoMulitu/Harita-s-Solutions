using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library1
{
    class Controller
    {
        private List<Book> books = new List<Book>();
        private Random rand = new Random();

        public void Start()
        {
            StaticValues();
            ReadFile();
            Outout();
            Sale();
            MostExpensive();
            Cheapest();
        }

        private void StaticValues()
        {
            Book.vatRate = 0.1;
            ForeignBook.minPrice = 100;
        }

        private void ReadFile()
        {
            string language, author, title;
            int numberOfPages, purchasePrice, level;

            StreamReader sReader = new StreamReader("book.txt");
            
            while(!sReader.EndOfStream)
            {
                language=sReader.ReadLine();
                author = sReader.ReadLine();
                title = sReader.ReadLine();
                numberOfPages =int. Parse(sReader.ReadLine());
                purchasePrice = int.Parse(sReader.ReadLine());

                if (language=="English")
                {
                    books.Add(new Book(title, author, numberOfPages, purchasePrice));
                }
                else
                {
                    level = int.Parse(sReader.ReadLine()) - 1;
                    books.Add(new ForeignBook(title, author, numberOfPages, purchasePrice, language, level));
                }
            }
        }

        private void Outout()
        {
            Console.WriteLine("book information/n");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        private void Sale()
        {
            int TotalIncome=0;
            foreach (Book book in books)
            {
                TotalIncome += book.SalePrice;
            }
        }

        private void MostExpensive()
        {
            int mxPrice = int.MinValue;
            foreach (Book book in books)
            {
                if (mxPrice < book.SalePrice)
                {
                    mxPrice = book.SalePrice;
                }
            }
            Console.WriteLine("\nMost expensive book(s):");
        }

        private void Cheapest()
        {

            int mnPrice = int.MaxValue;
            foreach (Book book in books)
            {
                if (mnPrice > book.SalePrice)
                {
                    mnPrice = book.SalePrice;
                }
            }
            foreach (Book book in books)
            {
                if (mnPrice == book.SalePrice)
                {
                    Console.WriteLine(book);
                }

                Console.WriteLine("\nCheapest book(s):");
            foreach (Book book in books)
            {
                if (mnPrice == book.SalePrice)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
