using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Laptops
    {
        public string _laptopbrand;

    public string LaptopBrand
        {
            get { return _laptopbrand; }

            set {
                if (!string.IsNullOrWhiteSpace(value))
                    _laptopbrand = value;
                else
                    Console.WriteLine("Invalid Brand Name");
            }
        }

        public string LaptopModel { get; set; } = "default name";
    } 
}
