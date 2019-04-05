﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestone3Practice
{
    class inventoryManager
    {
        //product list
        private List<Product> items;
        
        //constructor
        public inventoryManager()
        {
            //initializing attributes
            items = new List<Product>();
        }

        public bool addItem(Product item)
        {
            if (items.Contains(item))
                return false;
            items.Add(item);
            return true;
        }

        public bool removeItem(Product item)
        {
            //Ability to remove an item from the list
            items.Remove(item);
            return true;
        }

        public bool restockItem(int count, Product item)
        {
            //Needs logic for restocking an item
            for(int i = 0; i < items.Count(); i++)
            {
                if(items[i] == item)
                {
                    items[i].stockQnty += count;
                }
            }
            return true;
        }

        public void displayItems()
        {
            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public Product findByID(string id)
        {
            //Searches for an item by its unique id
            Product result = null;
            for(int i = 0; i < items.Count; i++)
            {
                if(items[i].prodID == id)
                {
                    result = items[i];
                }
            }
            return result;
        }

        public Product findByGenre(string Genre)
        {
            //Searches for an item by its title
            Product result = null;
            for(int i = 0; i < items.Count; i++)
            {
                if (items[i].genre == Genre)
                {
                    result = items[i];
                }
            }
            return result;
        }

        public Product findByPrice(int Price)
        {
            //Searches for item by its price
            Product result = null;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].price == Price)
                {
                    result = items[i];
                }
            }
            return result;
        }
    }
}
