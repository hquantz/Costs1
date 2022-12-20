using System;
using static System.Console;

namespace Costs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string cont;
            int userInput;
            //Program header
            WriteLine("Ch 8 Costs by Hunter Quantz\n");

            Hardware mouse = new Hardware(1234, "optical mouse", 49.95);
            Hardware keyboard = new Hardware(9876, "wireless keyboard", 59.95);
            Repairs j241 = new Repairs(241, "Jones hard drive", 100);
            Repairs m572 = new Repairs(572, "Murphy blue screen", 200);

            mouse.displayInfo();
            keyboard.displayInfo();
            j241.displayInfo();
            m572.displayInfo();

            do
            {
                Write("\nWhich one is being processed? ");
                userInput = int.Parse(ReadLine());
                //After getting user input, am I supposed to compare it to the existing objects or create a type "object"
                //if I am supposed to compare it to an existing object why am I doing double work when I can just call the
                //method in the existing object?
                if(userInput == mouse.getID())
                {
                    
                }
                //Is this the correct idea?
                object box = userInput;
                //is this the correct idea or am I off base?
                if(box is Hardware temp) 
                {
                    WriteLine("hardware");
                }else if(box is Repairs tmp)
                {
                    WriteLine("repairs");
                }
                Write("Do you want to process another one? (y/n) ");
                cont = ReadLine();
            } while (cont != "n");

            //Program footer
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
    }
}