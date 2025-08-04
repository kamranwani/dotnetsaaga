using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Cars
    {
        private string _BrandName;
        private string _CarModel;
        private string _CarName;
        private int _Year;
        private decimal _Price;

        public static int _NumberOfUnits;


        public Cars() {
            _BrandName = "unknown";
            _CarModel="unknown"; ;
            _CarName = "unknown";
            _Year = 0;
            _Price = 0;
            _NumberOfUnits++;

        }    
       public Cars(string brandName, string carModel, string carName, int year, decimal price)
        {
            _BrandName = brandName;
            _CarModel = carModel;
            _CarName = carName;
            _Year = year;
            _Price = price;
            _NumberOfUnits++;
        }

       static Cars()
        {
            _NumberOfUnits = 0;
        }

        public Cars(Cars carcopy)
        {
            _BrandName = carcopy._BrandName;
            _CarModel = carcopy._CarModel;
            _CarName = carcopy._CarName;
            _Year = carcopy._Year;
            _Price = carcopy._Price;
            _NumberOfUnits++;
        }

        public void SetBrandName(string brandname)
        {
            if (!string.IsNullOrWhiteSpace(brandname))
                _BrandName = brandname;
            else
                Console.WriteLine("Invalid brand name");
        }

        public string GetBrandName()
        {
            return _BrandName;
        }
        public void SetCarModel(string carmodel)
        {
            if (!string.IsNullOrWhiteSpace(carmodel))
                _CarModel = carmodel;
            else
                Console.WriteLine("Invalid car model");
        }

        public string GetCarModel()
        {
            return _CarModel;
        }
        public void SetCarName(string carName)
        {
            if (!string.IsNullOrWhiteSpace(carName))
                _CarName = carName;
            else
                Console.WriteLine("Invalid car name");
        }

        public string GetCarName()
        {
            return _CarName;
        }

        public void SetYear(int year)
        {
            if (year > 1885 && year <= DateTime.Now.Year) 
                _Year = year;
            else
                Console.WriteLine("Invalid manufacturing year");
        }

        public int GetYear()
        {
            return _Year;
        }

        public void SetPrice(decimal price)
        {
            if (price >= 0)
                _Price = price;
            else
                Console.WriteLine("Invalid price");
        }

        public decimal GetPrice()
        {
            return _Price;
        }

        public  void ShowCarData()
        {
            Console.WriteLine($@"Car Details are:
Car Brand: {_BrandName}
Car Model: {_CarModel}
Car Name: {_CarName}
Manufacturing Year: {_Year}
Car Price: {_Price}
NumberOfCarUnits:{_NumberOfUnits}");
        }
    }
}
