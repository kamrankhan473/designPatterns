using DesignPatterns.CreationalDesignPatterns.FactoryMethod.Client;
using DesignPatterns.CreationalDesignPatterns.FactoryMethod.ConcreteProduct;
using DesignPatterns.CreationalDesignPatterns.FactoryMethod.FactoryInterface;
using DesignPatterns.CreationalDesignPatterns.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethod.ConcreteFactory
{
    public class FMethodXiaomiFactory : IFMethodMobileFactory
    {
        IFMethodMobile IFMethodMobileFactory.GetMobile(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.XiaomiRedMe:
                    return new XiaomiRedmi();
                case ModelType.XiaomiPro9:
                    return new XiaomiPro();
                default:
                    throw new Exception("invalid Model Type");
 
            }
        }
    }
}
