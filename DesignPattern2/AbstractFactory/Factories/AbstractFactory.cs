using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.AbstractFactory.Factories
{
    public class AbstractFactory
    {
        public IFactory GetFactory()
        {
            Console.WriteLine("Dog or cat?");
            var factoryType = Console.ReadLine();

            if (factoryType.ToLower() == "dog")
            {
                Console.WriteLine($"you typed {factoryType}, creating dog factory");
                return new DogFactory();
            }
            else if (factoryType.ToLower() == "cat")
            {
                Console.WriteLine($"you typed {factoryType}, creating cat factory");
                return new CatFactory();
            }
            else
            {
                Console.WriteLine($"No {factoryType} factory found");
                return null;
            }
        }
    }
}
