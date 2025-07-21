using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Calculations
    {
        public void Calculation(params int []arr)
        {
           int sum = 0;
           foreach(int i in arr) { sum += i; }
           Console.WriteLine(sum);
            
        }
    }
}
