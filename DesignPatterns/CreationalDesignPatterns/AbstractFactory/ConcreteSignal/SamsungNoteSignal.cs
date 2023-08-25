using DesignPatterns.CreationalDesignPatterns.AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactory.ConcreteSignal
{
    internal class SamsungNoteSignal : ISignal
    {
        public void GetMobileSignalStrength()
        {
            Console.WriteLine("Abstract Factory Samsung signal strength is good....");
        }
    }
}
