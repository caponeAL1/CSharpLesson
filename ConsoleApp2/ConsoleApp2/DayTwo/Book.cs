using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayTwo
{
    internal class Book
    {
        public int BookId { get; set; }
        public string CustomerName { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string TotalAmount { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
        
        public override string ToString()
        {
            return $"BookID:{this.BookId},Name:{CustomerName},BookName:{BookName},AuthorName:{AuthorName},Amount:{TotalAmount}\n" +
                    $"Address:{Address}";
                     
        }

    }
    internal class Details
    {
        public static void BookDetails()
        {
            Book firstPerson = new Book();
            firstPerson.BookId = 1;
            firstPerson.CustomerName = "Aravind LN";
            firstPerson.BookName = "American Prometheus";
            firstPerson.AuthorName = "Bird,kai,Sherwin,Martin J";
            firstPerson.TotalAmount = "800";
            firstPerson.Address = "Chennai";
            String value = firstPerson.ToString();
            Console.WriteLine(value);


        }
    }
}
