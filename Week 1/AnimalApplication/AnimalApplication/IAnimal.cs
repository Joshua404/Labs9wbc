using System;
namespace AnimalApplication
{
    public interface IAnimal
    {
        string MakeSound();
        string Name { get; set; }
    }
}
