    using MyFirstApp;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks.Dataflow;
using Current=MyFirstApp.Current;
using Saving=MyFirstApp.Savings;

internal class Program
{
    private static void Main(string[] args)
    {
        Current.Account curaccount = new Current.Account();
        //curaccount.DisplayAccountDetails();
        Saving.Account savaccount=new Saving.Account();
        //savaccount.DisplayAccountDetails();

       
        Current.Account curaccount2 = new Current.Account(100050076696,"Kamran","ParayPora",7006704866,"Kamraanwani@gmail.com","Ab. Rashid",20000);
        //curaccount2.DisplayAccountDetails();

        Saving.Account savaccount2 = new Saving.Account(220050097732, "Basit", "Baghat", 9797918917, "Basitmehraj@gmail.com", "Mehraj ud din", 1100);
        //savaccount2.DisplayAccountDetails();

        Current.Account curaccount3 = curaccount2;
        curaccount3.Address = "Habib Colony, Parray Pora";

        //savaccount2.DisplayAccountDetails();

        Saving.Account savaccount3 = new Saving.Account();


        savaccount3.AccountNumber = 332197540001;
        savaccount3.Name = "Faiq";
        savaccount3.ContactNumber = 9596455182;
        savaccount3.Email = "faiqaziz@gmail.com";
        savaccount3.Parentage = "Aziz Bhat";
        savaccount3.AddBalance(2100);

        curaccount3.DisplayAccountDetails();

        curaccount3.Withdrawal(250.50m);
        //Console.WriteLine(savaccount3.Balance);

        //Console.WriteLine("Accounts");

        //savaccount3.DisplayAccountDetails();
        //savaccount2.DisplayAccountDetails();
        //curaccount2.DisplayAccountDetails();
        //curaccount3.DisplayAccountDetails();





    }
}



