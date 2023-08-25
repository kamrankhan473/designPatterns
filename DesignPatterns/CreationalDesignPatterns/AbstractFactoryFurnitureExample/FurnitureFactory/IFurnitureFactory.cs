using DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureFactory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
