using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs
{
    internal class Repairs
    {
        private int id;
        private string name;
        private double cost;
        private static double SALES_TAX = 0.045;
        private static double MARK_UP = .1;

        //constructor
        public Repairs(int id, string name, double cost)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
        }

        //writes the id and name to the screen
        public void displayInfo() => WriteLine($"{this.id} {this.name}");
        //calculates the total cost.
        public double calcCost(ref double subtotal)
        {
            //variable to help keep code clean
            double total;
            //stores the cost in the subtotal variable so it can be accessed outside of the function.
            subtotal = cost;
            //calculates the total cost
            total = cost + (cost * SALES_TAX) + (cost * MARK_UP);
            return total;
        }

        public int getID() { return id; }

    }
}
