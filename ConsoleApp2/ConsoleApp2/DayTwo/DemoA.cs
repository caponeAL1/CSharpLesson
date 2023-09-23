using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayTwo
{
    internal class DemoA
    {
        int x = 123;
        static int y = 567;
        public static void FirstMethod()
        {
            
            int y = 5000;
            //Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(DemoA.y);
        }
        public void SecondMethod()
        {
            int y = 5000;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(DemoA.y);
        }
    }
    internal class DemoB
    {

    }
}
namespace ConsoleApp2.Gavs
{
    internal class DemoA
    {

    }
}
