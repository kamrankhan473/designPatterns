using DesignPatterns.CreationalDesignPatterns.AbstractFactory.ConcreteProduct;
using DesignPatterns.CreationalDesignPatterns.AbstractFactory.ConcreteSignal;
using DesignPatterns.CreationalDesignPatterns.AbstractFactory.FactoryInterface;
using DesignPatterns.CreationalDesignPatterns.AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactory.ConcreteFactory
{
    internal class AbstractXiaomiFactory : IMobileFactory
    {
        public IMobile GetMobile(AbstractModelType modelType)
        {
            switch (modelType)
            {
                case AbstractModelType.XiaomiRedMe:
                    return new XiaomiRedmi();
                default:
                    throw new Exception("Invalid model type");
            }
        }

        public ISignal GetMobileSignalStrength(AbstractModelType modelType)
        {
            switch (modelType)
            {
                case AbstractModelType.XiaomiRedMe:
                    return new XiaomiRedmiSignal();
                default:
                    throw new Exception("Invalid model type");
            }
        }
    }
}
