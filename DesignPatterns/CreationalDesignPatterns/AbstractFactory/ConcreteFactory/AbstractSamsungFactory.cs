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
    internal class AbstractSamsungFactory : IMobileFactory
    {
        public IMobile GetMobile(AbstractModelType modelType)
        {
            switch (modelType)
            {
                case AbstractModelType.SamsungNote12:
                    return new SamsungNote();
                default:
                    throw new Exception("Invalid model type");
            }
        }

        public ISignal GetMobileSignalStrength(AbstractModelType modelType)
        {
            switch (modelType)
            {
                case AbstractModelType.SamsungNote12:
                    return new SamsungNoteSignal();
                default:
                    throw new Exception("Invalid model type");
            }
        }
    }
}
