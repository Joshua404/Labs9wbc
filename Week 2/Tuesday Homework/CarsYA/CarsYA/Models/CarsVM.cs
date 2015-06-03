using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsYA.Models
{
    public class CarsVM
    {
         public Cars Cars { get; set; }

        public CarsVM()
        {
            this.Cars = new Cars();
        }
    }
}