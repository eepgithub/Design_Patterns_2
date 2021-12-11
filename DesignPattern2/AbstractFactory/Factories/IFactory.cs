using DesignPattern2.AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.AbstractFactory.Factories
{
    public interface IFactory
    {
        IAnimal CreateAnimal(string name);
    }
}
