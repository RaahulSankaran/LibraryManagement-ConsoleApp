using ConsoleApp1.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("               Book App     ");
            Console.WriteLine("============================================");
            Console.WriteLine("         1.Adding books");
            Console.WriteLine("         2.Display All books");
            Console.WriteLine("         3.Search by Author");
            Console.WriteLine("         4.Search by Title");
            Console.WriteLine("         5.No of books present in Stock");
            Console.WriteLine("         6.Delete book");
            Console.WriteLine("         7.Modify the price of book");
            Console.WriteLine("         8.Check available of Book");
            Console.WriteLine("         Press X to Exit");
            Console.WriteLine("============================================");
            Console.WriteLine("Select Operation");
            Console.WriteLine("============================================");
            var bookrecord = new BookRecords();
            var UserInput = Console.ReadLine();

            while(true) 
            {   
                switch (UserInput) 
                {
                    case "1":
                        Console.WriteLine("Enter Book Name");
                        var subject = Console.ReadLine();
                        Console.WriteLine("Enter Author Name");
                        var author = Console.ReadLine();
                        Console.WriteLine("Enter Title of Book");
                        var title = Console.ReadLine();
                        Console.WriteLine("Enter Price Name");
                        var price = Convert.ToDouble(Console.ReadLine());
                        var newBook = new BookOnaSubject(subject,author,title,price);
                        bookrecord.AddBook(newBook);
                        break;
                    case "2":
                        bookrecord.DisplayAllBooks();
                        break;
                    case "3":
                        Console.WriteLine("Enter Author name for Search");
                        string bookauthor = Console.ReadLine();
                        bookrecord.SearchByAuthor(bookauthor);
                        break;
                    case "4":
                        Console.WriteLine("Enter Title name for Search");
                        string booktitle = Console.ReadLine();
                        bookrecord.SearchByTitle(booktitle); 
                        break;
                    case "5":
                        bookrecord.BookCount();
                        break;
                    case "6":
                        Console.WriteLine("Enter the Title of the Book to Delete");
                        var delbook = Console.ReadLine();
                        bookrecord.DeleteBook(delbook);
                        bookrecord.DisplayAllBooks();
                        break;
                    case "7":
                        Console.WriteLine("Enter the book to modify the price");
                        string searchtitle = Console.ReadLine();
                        Console.WriteLine("Enter the price of the book");
                        var modifyprice = Convert.ToDouble(Console.ReadLine());
                        bookrecord.ModiifyPrice(searchtitle,modifyprice);
                        break;
                    case "8":
                        Console.WriteLine("Enter the Name of the subject");
                        string avai = Console.ReadLine();
                        bookrecord.CheckAvailable(avai);    
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Enter the valid operation");
                        return;
                }
                Console.WriteLine("============================================");
                Console.WriteLine("               Book App     ");
                Console.WriteLine("============================================");
                Console.WriteLine("         1.Adding books");
                Console.WriteLine("         2.Display All books");
                Console.WriteLine("         3.Search by Author");
                Console.WriteLine("         4.Search by Title");
                Console.WriteLine("         5.No of books present in Stock");
                Console.WriteLine("         6.Delete book");
                Console.WriteLine("         7.Modify the price of book");
                Console.WriteLine("         8.Check available of Book");
                Console.WriteLine("         Press X to Exit");
                Console.WriteLine("============================================");
                Console.WriteLine("select Operation");
                Console.WriteLine("============================================");
                UserInput = Console.ReadLine();
            }
        }
    }
}
