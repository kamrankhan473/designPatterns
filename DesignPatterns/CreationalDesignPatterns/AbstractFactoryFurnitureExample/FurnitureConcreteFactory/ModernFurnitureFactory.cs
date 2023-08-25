using DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureConcreteProduct;
using DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureFactory;
using DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureConcreteFactory
{
    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
           return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
