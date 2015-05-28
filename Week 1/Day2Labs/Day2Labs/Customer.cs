using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Labs
{
    public class Customer
    {

        //public Customer()
        //{
        //    this.BillingAddress = new Address();
        //    this.ShippingAddress = new Address();
        //}

        ////public Customer()
        ////{
        ////    this.FirstName = "Jane";
        ////}

        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        //public Address BillingAddress { get; set; }
        //public Address ShippingAddress { get; set; }



        //public Customer(string name, int id, string type, decimal amount, bool isOpen)
        //{
        //this.Name = name;
        //this.ID = id;
        //this.Type = type;
        //this.Amount = amount;
        //this.IsOpen = isOpen;
        //}

        public Customer() {
            this.CheckingAccount = new Account();
            this.SavingsAccount = new Account();
        
        }

        public Account CheckingAccount { get; set; }
        public Account SavingsAccount { get; set; }

        
    }
}
