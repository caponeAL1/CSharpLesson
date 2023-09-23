using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayThree
{
    internal abstract class Book
    {
        public Book()
        {
            Console.WriteLine("Book Constructor");
        }
        public abstract void OpenBook();
    }
}
