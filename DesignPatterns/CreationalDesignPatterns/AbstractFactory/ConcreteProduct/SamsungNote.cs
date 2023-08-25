using DesignPatterns.CreationalDesignPatterns.AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactory.ConcreteProduct
{
    internal class SamsungNote : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Abstract Samsung Note is created.....");
        }
    }
}
