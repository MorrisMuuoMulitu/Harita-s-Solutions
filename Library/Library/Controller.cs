using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{

    class Controller
    {
        List<Book> books = new List<Book>();

      

        public void Start()
        {
            StaticValue();
            ReadBook();
            PrintOutput("Book data: ");
        }

        private void PrintOutput(string title)
        {
            Console.WriteLine(title);
            foreach (Book item in books)
            {
                Console.WriteLine(item);
            }
           
        }

        private void ReadBook()
        {

            string language;
            string title;
            string author;
            //string pages;
            //string purchasePrice;

            StreamReader readdata = new StreamReader("books.txt");

            while (!readdata.EndOfStream)
            {

                Book yousholdread;

                language = readdata.ReadLine();
                title = readdata.ReadLine();
                author = readdata.ReadLine();
                int pages = int.Parse(readdata.ReadLine());
                int numwords = int.Parse(readdata.ReadLine());
                int purchasePrice = int.Parse(readdata.ReadLine());

                if (language == "English")
                {
                    books.Add(new Book(title, author, numwords, pages, purchasePrice));
                    
                }

                else
                {
                    books.Add(new ForeignBook(title, author, numwords, pages, purchasePrice, language));
                }


                yousholdread = new Book(title, author, numwords, pages, purchasePrice);

                books.Add(yousholdread);
            }

            readdata.Close();


        }

        private void StaticValue()
        {
            Book.VatRate = 0.27;    
                
       }


    }
}
