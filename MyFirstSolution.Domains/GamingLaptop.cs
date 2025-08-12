using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstSolution.Domains;

public class GamingLaptop : Laptop
{

    public GamingLaptop() {
        _brand = "Asus Rog";
        Price = 112000.00m;
    }

    public void PrintX()
    {
        Console.WriteLine(x);
    }
}
