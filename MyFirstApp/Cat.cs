using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Cat
    {
        public string name;
        public string voice;
        public int? legs;
        string type;

        public static int catType;


        public Cat()
        {
            name = "anonymous";
            voice = "unknown";
            legs = 0;
            type = "undefined";
        }

        public Cat(string name, string voice, int? legs, string type)
        {

            this.name = name;
            this.voice = voice;
            this.type = type;
            this.legs = legs ?? 0;
            catType++;
        }

        public Cat(Cat cat2)
        {
            name = cat2.name;
            voice = cat2.voice;
            legs = cat2.legs ?? 0;
            type = cat2.type;
            catType++;
        }

        static Cat()
        {
            catType = 0;
        }

        public void ShowSheepData()
        {
            Console.WriteLine($@"this is a {name} object.
it makes {voice}sound
it has {legs}legs
{type} type. 
Currently we have {catType} types of snake in our class");


        }
    }
}
