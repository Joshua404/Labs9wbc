using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsYA.Models
{
    public class AddCarsVM
    {
        public AddCars AddCars { get; set; }

        public AddCarsVM()
        {
            this.AddCars = new AddCars();
        }

    }
}