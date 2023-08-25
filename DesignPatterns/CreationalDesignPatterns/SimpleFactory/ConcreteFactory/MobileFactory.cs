
using DesignPatterns.CreationalDesignPatterns.SimpleFactory.Client;
using DesignPatterns.CreationalDesignPatterns.SimpleFactory.ConcreteProduct;

namespace DesignPatterns.CreationalDesignPatterns.SimpleFactory.ConcreteFactory
{
    internal class MobileFactory
    {
        public static ISMethodMobile GetMobile(BrandType brandType)
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
