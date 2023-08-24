// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationalDesignPatterns.SimpleFactory;
using DesignPatterns.CreationalDesignPatterns.SimpleFactory.Client;
using DesignPatterns.CreationalDesignPatterns.SimpleFactory.ConcreteFactory;


#region [Simple Factory]

IMobile samsung = MobileFactory.GetMobile(BrandType.Samsung);
samsung.GetMobile();

IMobile xiaomi = MobileFactory.GetMobile(BrandType.Xiaomi);
xiaomi.GetMobile();

#endregion







Console.ReadLine();