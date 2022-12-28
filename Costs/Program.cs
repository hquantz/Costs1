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
            int userInput, amountSold;
            object generic;
            double  subTotal = 0.0, total, tax;
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
                try{
                    Write("\nWhich one is being processed? ");
                    userInput = int.Parse(ReadLine());
                    //After getting user input, am I supposed to compare it to the existing objects or create a type "object"
                    //if I am supposed to compare it to an existing object why am I doing double work when I can just call the
                    //method in the existing object?
                    if(userInput == mouse.getID())
                    {
                        generic = mouse;
                    }else if(userInput == keyboard.getID()){
                        generic = keyboard;
                    }else if(userInput == j241.getID()){
                        generic = j241;
                    }else{
                        generic = m572;
                    }
                    object box = userInput;
                    if(generic is Hardware temp) 
                    {
                        Write("How many sold? ");
                        amountSold = int.Parse(ReadLine());
                        total = temp.calcCost(ref subTotal, amountSold);
                        tax = total - subTotal;//calcs tax for sale.
                        WriteLine($"Subtotal = {subTotal:C}");
                        WriteLine($"Tax = {tax:C}");
                        WriteLine($"Total Cost = {total:C}");
                    }else if(generic is Repairs tmp)
                    {
                        total = tmp.calcCost(ref subTotal);
                        tax = total - subTotal;//calcs tax for repair
                        WriteLine($"Subtotal = {subTotal:C}");
                        WriteLine($"Fees and Tax = {tax:C}");
                        WriteLine($"Total Cost = {total:C}");
                    }
                }catch(FormatException fe){
                    WriteLine(fe.Message);
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