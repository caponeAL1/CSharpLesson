using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayTwo
{
    internal class Box
    {
        public static int height;
        public int width;
        public const String type = "wooden";
        public int GetHeight() { return height; }
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            Box.height = 100;
            //Box.width = 100;
            Box firstBox = new Box();
            Box secondBox = new Box();
            firstBox.width = 12345;
            secondBox.width = 100;
            Console.WriteLine($"First Box= {firstBox.width}, {firstBox.GetHeight()}");
            Console.WriteLine($"second Box={secondBox.width},{secondBox.GetHeight()}");
            Box.height = 5555;
            Console.WriteLine(Box.type);
            //Box.type = "Glass";
            Console.WriteLine($"First Box= {firstBox.width}, {firstBox.GetHeight()}");
            Console.WriteLine($"second Box={secondBox.width},{secondBox.GetHeight()}");

        }
    }
}
