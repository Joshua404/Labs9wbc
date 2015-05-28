using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Product
    {
        //Recent Way
        //public string Name { get; set; }


        //Old Way
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                if (String.IsNullOrWhiteSpace(value)) {
                    throw new Exception("Bad value!");
                }
                _name = value;
            }
        }
        


        public decimal Price { get; set; }

        public decimal GetTotalPrice()
        {
            return GetTotalPrice(0.08m);
        }

        public decimal GetTotalPrice(decimal taxRate)
        {
            return GetTotalPrice(0.08m, 0m);
        }

        public decimal GetTotalPrice (decimal taxRate=0.08m, decimal discount=0m)
        {
            return (this.Price + (this.Price * taxRate)) - discount;

         }



    }
}
