using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.AbstractFactory.Animals
{
    public class Dog : IDog
    {
        public string Name { get; set; }
        public Dog(string name)
        {
            Name = name;
        }


    }
}
