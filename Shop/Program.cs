using System;

namespace Shop
{
    /// <summary>
    /// The Main Program Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Creat the User of our program
            User user = new User("Bob",
                                 "Warsaw, Regulska 5/45", 
                                 10000, 
                                 0);
            // Print User info
            user.GetUserInfo();
            
            // Creat the Product Beer
            Beer doll = new Beer(500, 
                                 "Książec", 
                                 "Polish",
                                 0.05);
            // Print Beer info
            doll.ShowInfo();

            // Creat the Product Milk
            Milk condom = new Milk(100,
                                   "Milkavita",
                                   "Italy",
                                   0.03);
            // Print Milk info
            condom.ShowInfo();

            // Creat the Product Cookies
            Cookies aphrodisiac = new Cookies(250,
                                   "Hit",
                                   "Polish",
                                   "With chocolate");
            // Print Cookies info
            aphrodisiac.ShowInfo();

            // Upcast product class childrens to main class and creating array of Products
            Product[] product = new Product[]
            {
                doll,
                condom,
                aphrodisiac
            };

            // Creating Informer class
            Informer informer = new Informer();

            // Infinity loop where program works
            while (true)
            {
                Console.WriteLine($"Hello, {user.Name}, your balance {user.Balance}");
                Console.WriteLine(new String('-', 25));

                // Show the list of products
                for(int i = 0; i < product.Length; i++)
                {
                    Console.WriteLine($"Product {i+1} {product[i]}{product[i].Name}. Price: {product[i].Price}");
                }

                Console.WriteLine("\nSelect a product from the list and press Enter");
                int productNumber;
                string str = Console.ReadLine();
                

                if(int.TryParse(str, out int result))
                {
                    productNumber = result - 1;

                    if (productNumber >= 0 && productNumber < product.Length)
                    {
                        // Sell product to customer if user have enough money
                        if (product[productNumber].Price < user.Balance)
                            informer.Buy(user, product[productNumber]);
                        else
                            Console.WriteLine("You don't have enough funds");
                    }
                    else Console.WriteLine("There is no such item");
                }
                else Console.WriteLine("Please enter the item number");
                
            }

        }
    }
}
