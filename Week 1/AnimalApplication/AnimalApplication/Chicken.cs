using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApplication
{
    public class Chicken: IAnimal, IBird
    {
        public string Name { get; set; }
        public string MakeSound()
        {
            return "BockBock";
        }
        public string TakeFlight()
        {
            return "Flap Flap Flap!";
        }
    }
}
