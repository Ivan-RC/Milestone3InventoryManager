using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestone3Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test inventory manager
            inventoryManager IM = new inventoryManager();
            //Make products to add
            Product p = new Product();
            p.title = "Friday The 13th";
            p.prodID = "1";
            p.price = 5;
            p.genre = "Horror";
            p.releaseDate = "May 9th, 1980";
            p.stockQnty = 0;
            Product p2 = new Product();
            p2.title = "The Conjuring";
            p2.prodID = "2";
            p2.price = 20;
            p2.genre = "Horror";
            p2.releaseDate = "July 19th, 2013";
            p2.stockQnty = 5;
            Product p3 = new Product();
            p3.title = "Avenger's Infinity War";
            p3.prodID = "3";
            p3.price = 30;
            p3.genre = "Fantasy";
            p3.releaseDate = "April 27, 2018";
            p3.stockQnty = 2;

            //Add them to Inventory Manager
            Console.WriteLine("Adding items to inventory...");
            IM.addItem(p);
            IM.addItem(p2);
            IM.addItem(p3);

            //Display Inventory Manager
            IM.displayItems();

            //Restocking Friday The 13th item
            Console.WriteLine("\nRestocking " + p.title);
            IM.restockItem(5, p);
            IM.displayItems();

            //Remove item from Inventory Manager
            Console.WriteLine("\nRemoving " + p.title + " from inventory...");
            IM.removeItem(p);
            IM.displayItems();

            

            //Searching for items by ID, genre, and price
            Console.WriteLine("\nSearching for item by ID...");
            Product target = IM.findByID("3");
            if(target == null)
            {
                Console.WriteLine("Item with that ID not found.");
            }
            else
            {
                Console.WriteLine("Found " + target);
            }
            Console.WriteLine("Searching for item by genre...");
            Product target2 = IM.findByGenre("Horror");
            if(target == null)
            {
                Console.WriteLine("Item of that genre not found.");
            }
            else
            {
                Console.WriteLine("Found  " + target2);
            }
            Console.WriteLine("Searching for item by price...");
            Product target3 = IM.findByPrice(30);
            if(target == null)
            {
                Console.WriteLine("Item with that price not found.");
            }
            else
            {
                Console.WriteLine("Found " + target3);
            }
        }
    }
    class Product
    {
        public string title { set; get; }
        public string prodID { set; get; }
        public double price { set; get; }
        public string genre { set; get; }
        public string releaseDate { set; get; }
        public int stockQnty { set; get; }
        

        public Product()
        {
            title = "";
            prodID = "";
            price = 0;
            genre = "";
            releaseDate = "";
            stockQnty = 0;
        }
        public override string ToString()
        {
            return "Title: " + title + ", Product ID: " + prodID + ", Price: $" + price + ", Genre: " + genre 
                +  ", Release Date: " + releaseDate + ", Stock Quantity: " + stockQnty;
        }
    }
}
