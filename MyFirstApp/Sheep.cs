using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Sheep
    {
        public string name;
        public string voice;
        public int? legs;
        string type;

        public static int sheepType;


        public Sheep() {
            name = "anonymous";
            voice = "unknown";
            legs = 0;
            type = "undefined";
        }

        public Sheep(string name, string voice, int? legs, string type)
        {

            this.name = name;
            this.voice = voice;
            this.type = type;
            this.legs = legs ?? 0;
            sheepType++;
        }

        public Sheep(Sheep sheep2)
        {
            name = sheep2.name;
            voice = sheep2.voice;
            legs = sheep2.legs ?? 0;
            type = sheep2.type;
            sheepType++;
        }

        static Sheep()
        {
            sheepType=0;
        }

        public void ShowSheepData()
        {
            Console.WriteLine($@"this is a {name} object.
it makes {voice}sound
it has {legs}legs
{type} type. 
Currently we have {sheepType} types of snake in our class");


        }
    }
}
