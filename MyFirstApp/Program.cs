using ProjectTwo;
using MyFirstApp;
internal class Program
{
    private static void Main(string[] args)
    {
        //program1 here 
        //Console.WriteLine("Enter your name");
        //string name = Console.ReadLine();
        //Console.WriteLine("Enter your age!");
        //string tempAge= Console.ReadLine();

        //bool isAge = int.TryParse(tempAge, out int age);
        //if (isAge && age >= 18) {
        //    Console.WriteLine($@"hello! {name} 
        //    you're {age} years old and eligible ");
        //    return;
        //} else {
        //    Console.WriteLine($@"{isAge} ,{age} is below 18 so not eligible");
        //}   

        //Program 2
        Console.WriteLine("Enter length");
        string tempLength = Console.ReadLine();
        Console.WriteLine("Enter breadth");
        string tempWidth = Console.ReadLine();
        bool isLength = float.TryParse(tempLength, out float length);
        bool isWidth = float.TryParse(tempWidth, out float width);
        if (isLength&&isWidth) { 
       float area= AreaAndPerimeter.CalArea(length, width);
        Console.WriteLine($"Area is {area}");
       float perimeter = AreaAndPerimeter.CalPerimeter(length, width);
        Console.WriteLine($"Perimeter is {perimeter}");
        }
    }
}