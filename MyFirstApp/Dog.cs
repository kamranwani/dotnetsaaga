using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstApp
{
    internal class Dog
    {
        public string name;
        public string voice;
        public int? legs;
        string type;

        public static int dogType;
        public Dog() {
            name = "anonymous";
            voice = "unknown";
            legs = 0;
            type = "undefined";
        }

        public Dog(string name, string voice, int? legs, string type)
        {

            this.name = name;
            this.voice = voice;
            this.type = type;
            this.legs = legs ?? 0;
            dogType++;
        }

        public Dog(Dog dog2)
        {
            name = dog2.name;
            voice = dog2.voice;
            legs = dog2.legs ?? 0;
            type = dog2.type;
            dogType++;
        }

        static Dog()
        {
            dogType = 0;
        }
        public void ShowDogData()
        {
            Console.WriteLine($@"this is a {name} object.
it makes {voice}sound
it has {legs}legs
{type} type. 
Currently we have {dogType} types of snake in our class");
        }
    }
}
