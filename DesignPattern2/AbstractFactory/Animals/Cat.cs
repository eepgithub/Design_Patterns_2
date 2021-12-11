using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.AbstractFactory.Animals
{
    public class Cat : ICat
    {
        public string Name { get; set; }
        public Cat(string name)
        {
            Name = name;
        }





    }
}
