using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs
{
    internal class Hardware
        {
            private int id;
            private string name;
            private double cost;
            private static double SALES_TAX = 0.075;

            public Hardware(int id, string name, double cost)
            {
                this.id = id;
                this.name = name;
                this.cost = cost;
            }
            //writes the id and name to the screen
            public void displayInfo() => WriteLine($"{this.id} {this.name}");

            public double calcCost(ref double subTotal, double qty)
            {
                double total;
                subTotal = cost * qty;
                total = subTotal + (subTotal * SALES_TAX);
                return total;
            }

        public int getID() { return id; }
        }

}
