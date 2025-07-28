using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Student
    {
       public string name;
       public int age;
        //public static int count;
        public Student()
        {
            Console.WriteLine("default constructor called");
        }
        public Student(string name,int age)
        {
            this.name = name;
            this.age = age; 
        }

        
        public Student(Student other)
        {
            this.name = other.name;
            this.age = other.age;
        }

 


        public void DisplayData()
        {
            Console.WriteLine($"person data is name:{name} age:{age}");
        }
    }

}
