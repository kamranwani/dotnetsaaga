    using MyFirstApp;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks.Dataflow;

internal class Program
{
    private static void Main(string[] args)
    {
       Cars car=new Cars();
        car.SetBrandName("Hyundai");
        car.SetCarName("i20 sports");
        car.SetPrice(104000.11m);
        car.SetCarModel("i2001ddwKml");
        car.SetYear(2025);

        Console.WriteLine(car.GetBrandName()); ;
        
        //car.ShowCarData();

        Cars bmw=new Cars("bmw","BKLPAJDHAAN","M30D",2024,4521000.22m);
        //bmw.ShowCarData();

        Cars bmwCopy = bmw;
        bmwCopy.ShowCarData();

        Cars mercedes = new Cars(bmw);
        mercedes.SetBrandName("mercedes");
        mercedes.ShowCarData();
    }
    }



