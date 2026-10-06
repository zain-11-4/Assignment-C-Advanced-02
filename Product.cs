using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C__Advanced_02
{
    internal class Product
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
        public double Price { get; set; }
        public int Stock { get; set; }

        public List<Product> SearchProducts(List<Product> products, Func<Product, bool> func)
        {
            List<Product> result = new List<Product>();
            foreach (var product in products)
            {
                if (func(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }

        public override string ToString()
        {
            return $"ID : {Id} , Name {Name} , Category : {Category} , price {Price} , stock {Stock}; ";
        }








    }
}
