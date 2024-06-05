using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BookRecords
    {
        private List<BookOnaSubject> _books { get; set; } = new List<BookOnaSubject>(capacity:10);

        private void DisplayBookDetail(BookOnaSubject book)
        {
            Console.WriteLine(book.ToString());
            //var table = new ConsoleTable("Book Id", "Book Subject", "Book Author", "Book Title", "Book Price");
            Console.WriteLine($"Book ID :{book.id} \t\t\t Book subject : {book.Subject} \t\t\t " +
                $"Book Author : {book.Author} \t\t\t Book Title : {book.Title} \t\t\t Book Price : {book.Price}");
            //Console.WriteLine(book.ToString());
        }
        private void DisplayBookDetails(List<BookOnaSubject> books) 
        {
            Console.WriteLine("Books");
            foreach (var book in books)
            {
                Console.WriteLine($"Book ID :{book.id} \t\t\t Book subject : {book.Subject} \t\t\t " +
                $"Book Author : {book.Author} \t\t\t Book Title : {book.Title} \t\t\t Book Price : {book.Price}");
                //Console.WriteLine(book.ToString());
            }
        }
        public void AddBook(BookOnaSubject book) 
        {
            var id = (_books.Count == 0)?0:_books.Count;
            var countmath = _books.Count(c => c.subject_id == 0);
            var countchem = _books.Count(c => c.subject_id == 1);
            var countphy = _books.Count(c => c.subject_id == 2);
            book.id=id+1;
            if((book.Subject == "MATHS") &&(countmath<5))
            {
                book.subject_id = 0;
                _books.Add(book);
                Console.WriteLine($"Added Successfully");
            }
            else if((book.Subject == "CHEMISTRY") && (countchem<5)) 
            {
                book.subject_id = 1;
                _books.Add(book);
                Console.WriteLine("Added Successfully");
            }
            else if((book.Subject == "PHYSICS")&& (countphy < 5))
            {
                book.subject_id=2;
                _books.Add(book);
                Console.WriteLine("Added Successfully");
            }
            else if(_books.Count>15) 
            {
                Console.WriteLine("Books Reaches High");
            }
            else
            {
                Console.WriteLine("The Book is not belong to this section kindly save physics, maths and chemistry");
            }
            
        }
        public void DeleteBook(string title)
        {
            var book = _books.Find(b=>b.Title==title);
            if(book==null) 
            {
                Console.WriteLine("Book Cant Found");
            }
            else
            {
                book.inStock = false;
                _books.Remove(book);
                Console.WriteLine("Deleted Succesfully");
            }
        }
        public void DisplayAllBooks()
        {
            if(_books.Count==0)
            {
                Console.WriteLine("Zero Record");
            }
            else { DisplayBookDetails(_books); }
        }
        public void SearchByTitle(string title)
        {
            var book = _books.FirstOrDefault(b=>b.Title==title);
            if(book!=null) 
            {
                DisplayBookDetail(book);
            }
            else { Console.WriteLine("Book not Found"); }
        }
        public void SearchByAuthor(string author) 
        {
            var book = _books.FindAll(b => b.Author == author);
            if(book!=null) 
            {
                DisplayBookDetails(book);
            }
            else { Console.WriteLine("Book not Found"); }
        }
        public void BookCount()
        {
            int count = _books.Count;
            if (count == 0)
                Console.WriteLine("Zero Record");
            else
                Console.WriteLine($"Number of books are : {count}");
        }

        public void ModiifyPrice(string title,double price)
        {
            var index = _books.Find(c=>c.Title==title);
            if (index != null)
            {
                var modify = index.Price = price;
                Console.WriteLine("Modified Successfully");
            }
            else Console.WriteLine("Record not Match");
        }
        public void CheckAvailable(string sub)
        {
            var avai = _books.Count(c=>c.Subject==sub);
            if (avai != 0) Console.WriteLine($"Stock available Count : {avai}");
            else Console.WriteLine("Stock not available");
        }

    }
       
}
