using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    class Book
    {
        public int id { get; set; }
        public int subject_id { get; set; }
    }
    class BookOnaSubject :Book
    {
        public BookOnaSubject(string subject, string author, string title, double price)
        {
            Subject = subject.ToUpper().Trim();
            Author = author.ToUpper();
            Title = title.ToUpper();
            Price = price;
        }
        public string Subject { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public bool inStock { get; set; }

    }
       
}
