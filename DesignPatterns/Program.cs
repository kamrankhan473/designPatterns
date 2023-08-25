// See https://aka.ms/new-console-template for more information

using DesignPatterns.CreationalDesignPatterns.AbstractFactory;
using DesignPatterns.CreationalDesignPatterns.AbstractFactory.ConcreteFactory;
using DesignPatterns.CreationalDesignPatterns.AbstractFactory.ProductInterface;
using DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureConcreteFactory;
using DesignPatterns.CreationalDesignPatterns.AbstractFactoryFurnitureExample.FurnitureFactory;
using DesignPatterns.CreationalDesignPatterns.FactoryMethod;
using DesignPatterns.CreationalDesignPatterns.FactoryMethod.ConcreteFactory;
using DesignPatterns.CreationalDesignPatterns.FactoryMethod.FactoryInterface;
using DesignPatterns.CreationalDesignPatterns.SimpleFactory;
using DesignPatterns.CreationalDesignPatterns.SimpleFactory.Client;
using DesignPatterns.CreationalDesignPatterns.SimpleFactory.ConcreteFactory;



#region [Simple Factory]

ISMethodMobile samsung = MobileFactory.GetMobile(BrandType.Samsung);
samsung.GetMobile();

ISMethodMobile xiaomi = MobileFactory.GetMobile(BrandType.Xiaomi);
xiaomi.GetMobile();

Console.WriteLine("\n\n");

#endregion


#region [Factory Method]

//NOTE: Here IMobil reference must be from Factory Method ... Be carefull with name spaces. 
IFMethodMobileFactory xiaomiFactory = new FMethodXiaomiFactory();
DesignPatterns.CreationalDesignPatterns.FactoryMethod.Client.IFMethodMobile xaiomiMobile = xiaomiFactory.GetMobile(ModelType.XiaomiPro9);
xaiomiMobile.GetMobile();

IFMethodMobileFactory samsungFactory = new FMethodSamsungFactory();
DesignPatterns.CreationalDesignPatterns.FactoryMethod.Client.IFMethodMobile samsungMobile = samsungFactory.GetMobile(ModelType.SamsungNote12);
samsungMobile.GetMobile();

Console.WriteLine("\n\n");


#endregion


#region [Abstract Factory]

DesignPatterns.CreationalDesignPatterns.AbstractFactory.FactoryInterface.IMobileFactory xiaomiABFactory = new AbstractXiaomiFactory();
xiaomiABFactory.GetMobile(AbstractModelType.XiaomiRedMe).GetMobile();
xiaomiABFactory.GetMobileSignalStrength(AbstractModelType.XiaomiRedMe).GetMobileSignalStrength();


Console.WriteLine("\n\n");
#endregion


#region [Abstract Factoru FURNITURE EXAMPLE]

IFurnitureFactory furnitureFactory = new VictorianFurnitureFactory();
furnitureFactory.CreateSofa().HasLegs();
furnitureFactory.CreateSofa().SitOn();
furnitureFactory.CreateChair().HasLegs();
furnitureFactory.CreateChair().SitOn();

#endregion

Console.ReadLine();