using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Snake
    {
        public string name;
        public string voice;
        public int? legs;
        string type;

        public static int snakeType;

        public Snake() {

            name = "anonymous";
            voice = "unknown";
            legs = null;
            type = "undefined";
            snakeType++;
        }

        public Snake(string name,string voice, int? legs, string type)
        {

            this.name = name;
            this.voice = voice;
            this.type = type;
            this.legs = legs??0;
            snakeType++;
        }

        public Snake(Snake snake2)
        {
            name= snake2.name;
            voice= snake2.voice;
            legs = snake2.legs;
            type = snake2.type;
            snakeType++;
        }

         static Snake()
        {
            snakeType = 0;
            
        }

        public  void ShowSnakeData() {
            Console.WriteLine($@"this is a {name} object.
it makes {voice}sound
it has {legs}legs
it is of {type} type. 
Currently we have {snakeType} types of snake in our class");
        
        
        }
    }
}
