using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstApp
{
    internal class MobilePhones
    {
      private string _brand;
        private decimal _price;
        private int _manufactureYear;
        private static int _totalPhonesMade;

        public string Brand
        {
            get 
            { 
                return _brand; 
            }
               set 
            { 
                if (!string.IsNullOrWhiteSpace(value))
                    _brand = value;
            else
                    Console.WriteLine("Invalid Brand Name");
            }
        }

        public decimal Price {
            get { return _price; }
            set
            {
                if (value > 0)
                    _price = value;
                else Console.WriteLine("Invalid price");
            }
        }

        public int ManufactureYear
        {
            get { return _manufactureYear; }
            set
            {
                if (value > 1990 && value <= DateTime.Now.Year)

                    _manufactureYear = value;
                else Console.WriteLine("Invalid Manufacture Year");
            }
        }

        public string Model { get; set; } = "default model name";



        public MobilePhones()
        {
            _brand = "unknown";
            _price = 0;
            _manufactureYear = 0;
            _totalPhonesMade++;
        }

        public MobilePhones(string brand, string model, decimal price, int year)
        {
            Brand = brand;
            Model = model;
            Price = price;
            ManufactureYear = year;
            _totalPhonesMade++;
        }

        static MobilePhones()
        {
            _totalPhonesMade = 0;
        }

        public void ShowMobiles()
        {
            Console.WriteLine($@"Mobile Details
{_brand}
{_price}
{_manufactureYear}
{Model}  
Currently we have {_totalPhonesMade} number of phones");


        }
    }
}
