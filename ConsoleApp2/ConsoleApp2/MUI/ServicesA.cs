using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.MUI
{
     class ServicesA
    {
        int x = 0;
        public void DoTaskA()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("Inside DoTaskA");
            Console.WriteLine("\t Thread ID:"+ id);
            //int x = 0;
            for (int icount = 0; icount <= 5; icount++)
            {
                x += icount;
                Console.WriteLine("\tID="+id + ": x=" + x+" icount="+icount);
                Thread.Sleep(1000);
            }
        }
    }
}
