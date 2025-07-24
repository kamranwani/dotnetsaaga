using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Demo
    {
        public int x = 10;
        public static int y = 20;

        public static void Show()
        {
            Console.WriteLine(y);
            //Console.WriteLine(x); static Method cannot access non static member
        }
    }

}
