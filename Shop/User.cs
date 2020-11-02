using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    /// <summary>
    /// The User class (represents the user of the shop)
    /// </summary>
    class User
    {
        // Name get and set method
        public string Name{ get; private set; }
        // Adres get and set method
        public string Adres { get; private set; }
        // Balance get and set method
        public double Balance { get; private set; }
        // Spent get and set method
        public double Spent { get; private set; }

        /// <summary>
        /// Basic User constructor 
        /// </summary>
        /// <param name="name"> user name </param>
        /// <param name="adres"> user adres </param>
        /// <param name="balance"> user balance </param>
        /// <param name="spent"> money that user spent </param>
        public User(string name, string adres, double balance = 0, double spent = 0)
        {
            Name = name;
            Adres = adres;
            Balance = balance;
            Spent = spent;
        }

        /// <summary>
        /// Method prints out information about user
        /// </summary>
        public void GetUserInfo()
        {
            Console.WriteLine("\nUser: " + Name + "\nAdres: " + Adres + "\nBalance: " + Balance + "\nSpent: " + Spent);
            Console.WriteLine(new String('-', 25));
        }

        /// <summary>
        /// Method reduce the price from User Balance and add the price ammount to 'Spent'
        /// </summary>
        /// <param name="price"></param>
        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }

    }
}
