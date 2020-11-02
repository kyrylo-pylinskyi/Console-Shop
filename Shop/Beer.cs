using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    /// <summary>
    /// Beer class represents the product in the shop
    /// </summary>
    class Beer : Product
    {
        // Alcohol content get and set method
        public double Alcohol { get; set; }
        /// <summary>
        /// Basic Beer constructor
        /// </summary>
        /// <param name="price"> Beer price </param>
        /// <param name="name"> Beer name </param>
        /// <param name="manufacturer"> Beer manufacturer </param>
        /// <param name="alcohol"> Beer alcohol content </param>
        public Beer(double price, string name, string manufacturer, double alcohol) : base(price, name, manufacturer)
        {
            Alcohol = alcohol;
        }

        /// <summary>
        /// Override ToString method to use it in Product main class
        /// </summary>
        public override string ToString()
        {
            return "Beer: ";
        }
        /// <summary>
        /// Method shows information about Beer
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Alcohol content: " + Alcohol);
            Console.WriteLine(new String('-', 25));
        }

    }
}
