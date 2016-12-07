using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Analyzer
{
    class Product
    {
        private string name;
        private double cost;

        public Product(string name_, double cost_)
        {
            name = name_;
            cost = cost_;
        }

        public string toString()
        {
            string return_string;
            return_string = "Product Name: " + name + "\n";
            return_string += "Cost: $" + cost + "\n";
            return return_string;
        }

    }
}
