using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    /// <summary>
    /// Сookies class represents the product in the shop
    /// </summary>
    class Cookies : Product
    {
        // Cookies Composition get and set method
        public string Composition { get; set; }
        /// <summary>
        /// Basic Cookies constructor
        /// </summary>
        /// <param name="price"> Cookies price </param>
        /// <param name="name"> Cookies Name </param>
        /// <param name="manufacturer"> Cookies manufacturer </param>
        /// <param name="composition"> Cookies composition </param>
        public Cookies(double price, string name, string manufacturer, string composition) : base(price, name, manufacturer)
        {
            Composition = composition;
        }

        /// <summary>
        /// Override ToString method to use it in Product main class
        /// </summary>
        public override string ToString()
        {
            return "Cookies: ";
        }

        /// <summary>
        /// Method shows information about Cookies
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Composition: " + Composition);
            Console.WriteLine(new String('-', 25));
        }

        // override get discount method to get price divided by 2 
        public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }
    }
}
