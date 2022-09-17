using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    class Journal:Product
    {
        public string Company;

        public override void GetInfo()
        {
            Console.WriteLine($"Company:{Company}");
        }
    }
}
