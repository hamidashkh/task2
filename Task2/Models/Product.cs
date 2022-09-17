using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    abstract class Product
    {
        public string Name;
        public double Price;

        public abstract void GetInfo();
        
    }
}
