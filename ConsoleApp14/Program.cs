using ConsoleApp14.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            // get all the product data 
            var products = GetData();

            // get all the discounts for all the products 
            var productsWithDiscount = GetPriceWithDiscount(products);

            // get all the products that are less than 500
            var productsLessThan500 = productsWithDiscount.Where(x => x.Price < 500 ).OrderByDescending(x => x.Price);

            // get the smartPhone with the highest rating from the phones less than 500 
            var bestSmartPhone = productsLessThan500.FirstOrDefault(x => x.Rating == productsLessThan500.Max(r => r.Rating));

            Console.WriteLine(" The Best Smart Phone is {0} with a price of {1} and The best Rating of {2}", 
                bestSmartPhone.Brand,string.Concat("R", bestSmartPhone.Price),bestSmartPhone.Rating);
        }
        public static List<Product> GetData()
        {
            var path = Configuration.Path;
            var productData = System.IO.File.ReadAllText(path);
            var products = JsonConvert.DeserializeObject<ProductList>(productData);
            return products.Products;
        }

        public static List<Product> GetPriceWithDiscount(List<Product> products)
        {
            foreach (var product in products)
            {
                int markdown = Convert.ToInt32(product.Price * (product.DiscountPercentage / 100));
                product.Price = product.Price - markdown;
            }

            return products;
        }    
    }
}
