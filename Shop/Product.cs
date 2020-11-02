using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    /// <summary>
    /// abstract class represents the Products in the Shop
    /// </summary>
    abstract class Product
    {
        // Price of the Product
        public double Price { get; set; }
        // Name of The Product
        public string Name { get; set; }
        // Manufacturer of Product
        public string Manufacturer { get; set; }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Product() { }

        /// <summary>
        /// Basic User constructor
        /// </summary>
        /// <param name="price"> Product price </param>
        /// <param name="name"> Product name </param>
        /// <param name="manufacturer"> Product manufacturer </param>
        public Product(double price, string name, string manufacturer)
        {
            Price = price;
            Name = name;
            Manufacturer = manufacturer;
        }

        /// <summary>
        /// Method shows information about product
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine(ToString() +
                               "\nName: " + Name +
                               "\nPrice: " + Price + " dollars" +
                               "\nManufacturer: " + Manufacturer);
        }

        /// <summary>
        /// Method sets discounts for customers
        /// </summary>
        /// <param name="user"> User </param>
        /// <returns> Price with discount </returns>
        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 1000)
                return Price;
            if (user.Spent < 5000)
                return Price * 0.9;
            else
                return Price * 0.8;
        }
    }
}
