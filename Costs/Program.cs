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
                //I am unsure what the project wants. It says to box the object and then find out what kind
                //of object it is. Does that mean I need to create another object or do I compare the user 
                //input to the existing objects and then assign the existing object to type object?
                //After boxing it do I unbox it back into a temporary version? If so, why would I not just
                //use the existing variable and method. I don't understand what the purpose of this exersize is
                //nor do I understand what the program is supposed to be doing by doing it this way. It seems like
                //needless duplication of work which we are supposed to be avoiding.
                userInput = int.Parse(ReadLine());
                if(userInput == mouse.getID())
                {
                    
                }
                object box = userInput;
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