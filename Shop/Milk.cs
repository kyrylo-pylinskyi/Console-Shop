using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    /// <summary>
    /// Milk class represents the product in the shop
    /// </summary>
    class Milk : Product
    {
        // Fats content get and set method
        public double Fats { get; set; }

        /// <summary>
        /// Bsic Milk constructor
        /// </summary>
        /// <param name="price"> Milk price </param>
        /// <param name="name"> Milk name </param>
        /// <param name="manufacturer"> Milk manufacturer </param>
        /// <param name="fats"> Milk fats </param>
        public Milk(double price, string name, string manufacturer, double fats) : base(price, name, manufacturer)
        {
            Fats = fats;
        }

        /// <summary>
        /// Override ToString method to use it in Product main class
        /// </summary>
        public override string ToString()
        {
            return "Milk: ";
        }

        /// <summary>
        /// Method shows information about Milk
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Fats: " + Fats);
            Console.WriteLine(new String('-', 25));
        }
    }
}
