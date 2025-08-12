using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSolution.Domains
{
    public class Laptop
    {
        protected string _brand;
        private decimal _price;
        protected int x = 10;

        public decimal Price
        {
            get { return _price; }
            set { 
                if (value > 100m)
                    _price = value;
                else
                    Console.WriteLine("Enter a valid price above RS 100");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Laptop Details are Brand Name:{_brand } Price:{Price}");
        }
    } 
}
