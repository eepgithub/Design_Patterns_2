using DesignPattern2.AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.AbstractFactory.Factories
{
    public class DogFactory : IFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Dog(name);
        }


    }
}
