using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    /// <summary>
    /// Informer class (informs the administration about the completed transaction)
    /// </summary>
    class Informer
    {
        /// <summary>
        /// Method to Buy some product in the shop
        /// </summary>
        /// <param name="user">the User costomer</param>
        /// <param name="product">the product User bought</param>
        public void Buy(User user, Product product)
        {
            // get the price of the product
            double price = product.GetDiscountPrice(user);
            // reduce the price of product from User balance
            user.ReduceBalance(price);
            // Print out information about transaction
            Console.WriteLine($"{user.Name} bought {product.Name} for {price} dollars");
        }
    }
}
