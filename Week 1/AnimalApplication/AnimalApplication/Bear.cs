using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApplication
{
    public class Bear: IAnimal
    {
        public string Name { get; set; }
        public string MakeSound()
        {
            return "Roar";
        }
    }
}
