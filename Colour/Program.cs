using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Colour
{
    class Program
    {
        static void Main(string[] args)
        {

            //Explains how to properly input the colour so that the program can understand it
            Console.WriteLine("Make sure that you spell it properly and use all lowercase");
            //Gives the option to choose a colour so that they know the options 
            Console.Write("What is your favouite colour, blue, yellow, purple or green?");
            //Makes UserValue equal what colour they imputed so that I can easily change the colour and what the words say 
            String userValue = Console.ReadLine();
            //Sets the message up as a string so that I can string or attach text to it
            String message = "";

            //This says that if the value that they inputed was blue than you can attach the words to the string message so that it can be read later
            if (userValue == "black")
            {
                message = "Black is the colour of a blood sucking crow, and it is a color most people don't know";

                //This changes the colour to blue when they input the colour blue
                Console.ForegroundColor = ConsoleColor.Black;

            }

            //once again this says that if they inputed the value yellow then change the message and colour to yellow
            else if (userValue == "white")
            {
                //This changes the message to yellow's message
                message = "The color of purity and innocence white is a true balance of all colors";
                //This changes the colour to yellow 
                Console.ForegroundColor = ConsoleColor.White;

            }

            //This says that if the value is purple, so if they entered purple than set the colour and words to purple's 
            else if (userValue == "purple")
            {
                //This sets the message to the purple one 
                message = "Purple is like a purple sunset you only see once in a blue moon";
                //And this changes the colour of the text so that it is magenta 
                Console.ForegroundColor = ConsoleColor.Magenta;

            }

            //this says that if the user enters green then you can change the settings below acrordingly
            else if (userValue == "orange")
            {
                //Changes the message to the colour green 
                message = "The colour of enthusiasm and emotion orange exudes warmth and joy";
                //this changes the colour to green
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            }

            //This says that if anyone except then accepted values is inputed than display this 
            else
            {
                //This says to write that they entered the incorect value and to show what they inputed in the place of the {0} 
                Console.WriteLine("You entered {0}, and that was not a valid anwser try again and make sure its all lowercase.", userValue);
         
            }

            //This tells it to write out the message which was changed above according to what the message was changed to above and in the proper colour
            Console.WriteLine(message);
            //This says to read anything that has been written out which in this case is the message about what colour they chose 
            Console.ReadLine();

         
        }
    }
}
