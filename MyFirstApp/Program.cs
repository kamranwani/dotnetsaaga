    using MyFirstApp;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks.Dataflow;

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

        //Program 8 
        //Area CalculateArea = new Area();
        //float squareArea = CalculateArea.CalArea(3);
        //Console.WriteLine(squareArea);

        //float rectangleArea = CalculateArea.CalArea(3,5);
        //Console.WriteLine(rectangleArea);

        //float circleArea = CalculateArea.CalArea(3, true);
        //Console.WriteLine(circleArea);

        //Program 9 

        //Student kamran = new Student();
        //Student chatgpt = new Student("chatgpt", 29);

        //Student third = new Student(chatgpt);

        //chatgpt.DisplayData();
        //third.DisplayData();


        //third.name = "kamran";
        //third.DisplayData();


        //chatgpt.name = "GPT";
        //chatgpt.DisplayData();

        //Program 10 

        //Book book1 = new Book();
        //book1.DisplayBook();
        //Book book2 = new Book("Atomic Habits", "James Clear", 2018);
        //book2.DisplayBook();
        //Book book3 = new Book(book2);
        //book3.DisplayBook();

        //book3.updateField("title", "Deep Work");
        //book3.DisplayBook();

        //book3.updateField("year", "2020");
        //book3.DisplayBook();

        //book2.updateField("author", "GPT");
        //book2.DisplayBook();

        //bool result = book2.IsSameBook(book3);
        //Console.WriteLine($"Book2 and Book3 are {(result ? "same" : "different")}");

        //Book.ShowTotalbooks();

        //Book[] library = new Book[3];
        //for (int i = 0; i < library.Length; i++) {
        //    library[i] = new Book();
        //    Console.WriteLine("enter title name");
        //    library[i].title = Console.ReadLine();
        //    Console.WriteLine("enter author name");
        //    library[i].author = Console.ReadLine();
        //    Console.WriteLine("enter year");
        //    string tempYear = Console.ReadLine();
        //    bool isYear = int.TryParse(tempYear, out int year);
        //    if (isYear)
        //    {
        //        library[i].year = year;
        //    }
        //}
        //int prevsBookyear = 0;

        //foreach (Book book in library)
        //{

        //    if (prevsBookyear < book.year)
        //    {
        //        prevsBookyear = book.year;
        //    }



        //}

        //Book.ShowLatestBook(prevsBookyear, library);

        //Program 11 

        //int smallNum = 100;
        //long bigNum;
        //double preciseValue = 1234.56;
        //int approxValue;

        //bigNum = smallNum;
        //approxValue = (int)preciseValue;
        //{
        //    Console.WriteLine($"{smallNum},{bigNum},{preciseValue},{approxValue}");





        //}

        //Program 12 

        Snake snake = new Snake("cobra", "hiss", null, "reptile");
        Console.WriteLine("before shallow copy");
        Console.WriteLine("----------");
        snake.ShowSnakeData();
        Console.WriteLine("----------");

        Snake snake2 = snake;
        snake2.name = "cobra updated";
        Snake snake3 = new Snake(snake);

        snake3.name = "python";

        Console.WriteLine("after shallow copy");

        snake.ShowSnakeData();
        Console.WriteLine("----------");

        snake2.ShowSnakeData();
        Console.WriteLine("----------");
        Console.WriteLine("after deep copy");
        Console.WriteLine("----------");
        snake3.ShowSnakeData();
        Console.WriteLine(Snake.snakeType);

        Sheep sheep = new Sheep();
        Cat cat = new Cat();
        Dog dog = new Dog();

        object []animalsArr = new object[5];


        animalsArr[0] = cat;
        animalsArr[1] = dog;
        animalsArr[2] = sheep;
        animalsArr[3] = snake;
        animalsArr[4] = snake3;

        foreach (object animal in animalsArr)
        {
            if (animal is Cat)
            {
                Cat myCat = animal as Cat;
                Console.WriteLine(myCat != null ? "is a cat" : "got null instead of cat");
            }
            else if (animal is Dog)
            {
                Dog myDog = animal as Dog;
                Console.WriteLine(myDog != null ? "is a dog" : "got null instead of dog");
            }
            else if (animal is Sheep)
            {
                Sheep mySheep = animal as Sheep;
                Console.WriteLine(mySheep != null ? "is a sheep" : "got null instead of sheep");
            }
            else if (animal is Snake) {
                Snake tempSnake = animal as Snake;
                Console.WriteLine(tempSnake != null ? "is a snake" : "got null instead of snake");
            }

            //part of program 7
            //    public static int Factorial(int num) {
            //    if (num == 0 || num == 1)
            //        return 1;
            //    return num * Factorial(num - 1);
            //}
        }
    }

}

