using DesignPatterns.CreationalDesignPatterns.AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactory.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile GetMobile(AbstractModelType modelType);
        ISignal GetMobileSignalStrength(AbstractModelType modelType);
    }
}
