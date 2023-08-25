using DesignPatterns.CreationalDesignPatterns.SimpleFactory.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.SimpleFactory.ConcreteProduct
{
    internal class Xiaomi : ISMethodMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Simple Factory Xiaomi Mobile....");
        }
    }
}
