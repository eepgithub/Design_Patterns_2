using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.AbstractFactory
{
    class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter

        public void Run()
        {
            var AbstractFactory = new Factories.AbstractFactory();

            AbstractFactory.GetFactory();
        }
    }
}
