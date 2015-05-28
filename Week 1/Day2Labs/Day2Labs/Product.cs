using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Labs
{
    class Product
    {

        public Product(string name, decimal price, int unitsInStock)
        {
            this.Name = name;
            this.Price = price;
            this.UnitsInStock = unitsInStock;
        }

        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }

    }
}
