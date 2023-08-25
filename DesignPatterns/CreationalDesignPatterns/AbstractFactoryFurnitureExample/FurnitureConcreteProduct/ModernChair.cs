using DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureConcreteProduct
{
    internal class ModernChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("Modern Chair has 4 legs.");
        }

        public void SitOn()
        {
           Console.WriteLine("Modern Chair.");
        }
    }
}
