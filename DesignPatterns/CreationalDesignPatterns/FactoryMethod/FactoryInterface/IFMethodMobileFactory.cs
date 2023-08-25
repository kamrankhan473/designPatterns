using DesignPatterns.CreationalDesignPatterns.FactoryMethod;
using DesignPatterns.CreationalDesignPatterns.FactoryMethod.Client;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethod.FactoryInterface
{
    /// <summary>
    /// Abstract Factory it can be an interface.
    /// </summary>
    public interface IFMethodMobileFactory
    {
        IFMethodMobile GetMobile(ModelType modelType);
    }
}
