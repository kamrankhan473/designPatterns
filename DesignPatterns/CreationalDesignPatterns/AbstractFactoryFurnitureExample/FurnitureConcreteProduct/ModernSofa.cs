using DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureConcreteProduct
{
    internal class ModernSofa : ISofa
    {
        public void HasLegs()
        {
            Console.WriteLine("Modern Sofa has 4 legs.");
        }

        public void SitOn()
        {
            Console.WriteLine("Modern Sofa.");
        }
    }
}
