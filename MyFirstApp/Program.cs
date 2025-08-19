using MyFirstApp;
using MyFirstSolution.Domains;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using Current=MyFirstApp.Current;
using Saving=MyFirstApp.Savings;

internal class Program
{
    private static void Main(string[] args)
    {
        GamingLaptop GL = new GamingLaptop();

        GL.DisplayDetails();
        
    }
}



