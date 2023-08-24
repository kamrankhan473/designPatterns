using DesignPatterns.SimpleFactory.Client;
using DesignPatterns.SimpleFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory.ConcreteFactory
{
    internal class MobileFactory
    {
        public static IMobile GetMobile(BrandType brandType)
        {
            switch (brandType)
            {
                case BrandType.Xiaomi:
                    return new Xiaomi();
                case BrandType.Samsung:
                    return new Samsung();   
                default:
                    throw new ArgumentException("Invalid Mobile Brand");
            }
        }
    }
}
