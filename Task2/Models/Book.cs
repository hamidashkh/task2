using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    class Book:Product
    {
        public string Author;
        public string Genre;

        public override void GetInfo()
        {
            Console.WriteLine($"Author:{Author}\nGenre{Genre}"); 
        }
    }
}
