using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayFour
{
    internal class WeekOneAnswer
    {
        public static void QuestionOne()
        {
            byte byteOne = 1;
            sbyte sbyteOne = 1;
            short shortOne = 1;
            int intOne = 1;
            long longOne = 1;
            float floatOne = 1.543f;
            double doubleOne = 2345.76534d;
            decimal decimalOne = 627637263.36263726372M;
            char charOne = 'A';
            bool boolOne = true;
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MaxValue);
        }
        public static void QuestionThreeA()
        {
            String strFriends = "Tom and Jerry are good friends"; string[] words = strFriends.Split(" ");
            int wordCount = words.Length;
            Console.WriteLine($"Word Count {wordCount}");
        }
        public static void QuestionThreeB()
        {
            String strFriends = "Tom and Jerry are good friends";
            Console.WriteLine(strFriends);
            // first Method
            char[] charData = strFriends.ToCharArray();
            int len = charData.Length;
            StringBuilder sb = new StringBuilder(len + 10);
            for (int i = len - 1; i >= 0; i--)
            {
                sb.Append(charData[i]);
            }
            Console.WriteLine(sb.ToString());
        }

    }
}
