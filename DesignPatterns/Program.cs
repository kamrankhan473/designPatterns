// See https://aka.ms/new-console-template for more information
using DesignPatterns.SimpleFactory;
using DesignPatterns.SimpleFactory.Client;
using DesignPatterns.SimpleFactory.ConcreteFactory;


IMobile samsung = MobileFactory.GetMobile(BrandType.Samsung);
samsung.GetMobile();


IMobile xiaomi = MobileFactory.GetMobile(BrandType.Xiaomi);
xiaomi.GetMobile();




Console.ReadLine();