using DesignPattern2.AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.AbstractFactory.Factories
{
    public class CatFactory : IFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Cat(name);
        }
    }
}
