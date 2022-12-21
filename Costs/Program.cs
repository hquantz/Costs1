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
            int userInput, amountSold, subTotal = 0, total, tax;
            object generic;
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
                if(generic is Hardware temp) 
                {
                    Write("How many sold? ");
                    amountSold = int.Parse(ReadLine());
                    total = temp.calcCost(ref subTotal, amountSold);
                    tax = total - subTotal;//calcs tax for sale.
                    WriteLine($"Subtotal = {subtotal:C}");
                    WriteLine($"Tax = {tax:C}");
                    WriteLine($"Total Cost = {total:C}");
                }else if(generic is Repairs tmp)
                {
                    Write("Which one is being processed? ");
                    userInput = int.Parse(ReadLine());
                    if(userInput == j241.getID()){
                        temp.calcCost()
                    }
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