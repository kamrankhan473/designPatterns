using DesignPatterns.CreationalDesignPatterns.FactoryMethod.Client;
using DesignPatterns.CreationalDesignPatterns.FactoryMethod.ConcreteProduct;
using DesignPatterns.CreationalDesignPatterns.FactoryMethod.FactoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethod.ConcreteFactory
{
    public class FMethodSamsungFactory : IFMethodMobileFactory
    {
        public IFMethodMobile GetMobile(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.SamsungNote12:
                    return new SamsungNote();
                case ModelType.SamsungZFold5:
                    return new SamsungZFold();
                default:
                    throw new Exception("Invalid Model type");
            }
        }
    }
}
