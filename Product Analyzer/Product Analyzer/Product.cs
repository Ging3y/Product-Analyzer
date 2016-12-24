using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Analyzer
{
    class Product
    {
        private int position;
        private string product;
        private string link;
        private string brand;
        private int sellers;
        private int variations;
        private double price;
        private string category;
        private int rank;
        private int sales;
        private double revenue;
        private int reviews;
        private double rating;
        private string type;

        public Product(int position_, string product_, string link_, string brand_, 
            int sellers_, int variations_, double price_, string category_,
            int rank_, int sales_, double revenue_, int reviews_, double rating_,
            string type_)
        {
            position = position_;
            product = product_;
            link = link_;
            brand = brand_;
            sellers = sellers_;
            variations = variations_;
            price = price_;
            category = category_;
            rank = rank_;
            sales = sales_;
            revenue = revenue_;
            reviews = reviews_;
            rating = rating_;
            type = type_;
        }

        public string toStringFullInfo()
        {
            string return_string;
            return_string = "Product Name: " + product + "\n";
            return_string += "Rank: " + rank + "\n";
            return_string += "Cost: $" + price + "\n";
            return_string += "Monthly Sales: " + sales + "\n";
            return_string += "Monthly Revenue: " + revenue + "\n";
            return_string += "Rating: " + rating + "\n";
            return return_string;
        }

        public string toString()
        {
            string return_string;
            return_string = "Product Name: " + product + "\n";
            return_string += "Cost: $" + price + "\n";
            return return_string;
        }

    }
}
