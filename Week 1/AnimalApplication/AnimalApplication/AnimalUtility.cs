using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApplication
{
    public class AnimalUtility
    {
        public static void DoSomething(IAnimal animal)
        {
            Console.WriteLine(animal.Name + animal.MakeSound());
            if (animal is IBird)
            {
                var bird = animal as IBird;
                Console.WriteLine(bird.TakeFlight());
            }
        }
    }
}
