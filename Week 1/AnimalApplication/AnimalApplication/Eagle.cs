using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApplication
{
    public class Eagle : IAnimal, AnimalApplication.IBird
    {

        public string Name { get; set; }
        public string MakeSound()
        {
            return "Screetch Ahg Ahg";

        }
        public string TakeFlight()
        {
            return "Flap Flap Flap!";
        }
    }
}
