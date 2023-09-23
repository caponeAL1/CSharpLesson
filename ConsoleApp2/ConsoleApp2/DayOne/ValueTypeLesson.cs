using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayOne// namespace is a logical boundary. 
{
    internal class ValueTypeLesson
    {
        public static void TestValueTypes()
        {
            char c1 = 'a';
            Console.WriteLine(c1);
            int x = c1;
            Console.WriteLine(x);

        }
        static void TestMethod()
        {
            Console.WriteLine("TEST");
        }
    }
}
