using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    class Library
    {
        public Product[] Products = new Product[0];

        public Product[] AddProduct(Product product)
        {
            
            
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = product;
            
            return Products;
        }
       
        public Product[] GetProductsByPrice(int minPrice,int maxPrice)
        {
            Product[] productPrice = { };
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Price>minPrice && Products[i].Price < maxPrice)
                {
                    Array.Resize(ref productPrice, productPrice.Length + 1);
                    productPrice[productPrice.Length - 1] = Products[i];
                }

            }return productPrice;
        }
        public Product[] GetProductByName(string name)
        {
            Product[] productName = { };
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Array.Resize(ref productName, productName.Length + 1);
                    productName[productName.Length - 1] = Products[i];
                }
               
            }
            return productName;
        }
    }
}
