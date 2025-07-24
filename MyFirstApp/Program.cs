using MyFirstApp;
using System.Security.Cryptography.X509Certificates;

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
        // Console.WriteLine("Enter length");
        // string tempLength = Console.ReadLine();
        // Console.WriteLine("Enter breadth");
        // string tempWidth = Console.ReadLine();
        // bool isLength = float.TryParse(tempLength, out float length);
        // bool isWidth = float.TryParse(tempWidth, out float width);
        // if (isLength&&isWidth) { 
        //float area= AreaAndPerimeter.CalArea(length, width);
        // Console.WriteLine($"Area is {area}");
        //float perimeter = AreaAndPerimeter.CalPerimeter(length, width);
        // Console.WriteLine($"Perimeter is {perimeter}");
        //DisplayingMessage.DisplayMsg(); error internal method

        //Program 3
        // Calculations calc = new Calculations();
        //calc.Calculation(200, 300, 400);

        //program4

        //Calculations cal =new Calculations();
        //int sum1=cal.Sum(5, 10);
        //Console.WriteLine(sum1);
        //float sum2 = cal.Sum(3.5f, 4.5f);
        //Console.WriteLine(sum2);

        //Program 5
        //Student[] stud = new Student[3];
        //for (int i = 0; i < 3; i++)
        //{
        //    stud[i] = new Student();
        //    Console.WriteLine("enter student name");
        //    stud[i].name = Console.ReadLine();
        //    stud[i].id = i;
        //    Student.count++;

        //}
        //Console.WriteLine($"Total Students are {Student.count}");

        //Program6
        //Employee emp1 = new Employee();
        //Employee emp2 = new Employee();

        //emp2.age = 30;


        //Console.WriteLine($"emp1 age is {emp1.age} and emp2 age is {emp2.age}");

        //Program 7
        //Console.WriteLine($"Enter Number for factorial");
        //string TempFactorialNumberInput = Console.ReadLine();
        //bool isValid = int.TryParse(TempFactorialNumberInput, out int FactNumber);
        //if (isValid && FactNumber >= 0) {
        //    int result = Factorial(FactNumber);
        //    Console.WriteLine($"Factorial of {FactNumber} is: {result}");
        //}
        //else
        //{ Console.WriteLine("Please enter valid input to generate factorial");
        //} 
        Area CalculateArea = new Area();
        float squareArea = CalculateArea.CalArea(3);
        Console.WriteLine(squareArea);

        float rectangleArea = CalculateArea.CalArea(3,5);
        Console.WriteLine(rectangleArea);

        float circleArea = CalculateArea.CalArea(3, true);
        Console.WriteLine(circleArea);
    }
    //part of program 7
    //    public static int Factorial(int num) {
    //    if (num == 0 || num == 1)
    //        return 1;
    //    return num * Factorial(num - 1);
    //}
}



