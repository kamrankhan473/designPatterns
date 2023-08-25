﻿using DesignPatterns.CreationalDesignPatterns.FactoryMethod.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethod.ConcreteProduct
{
    public class SamsungNote : IFMethodMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Factory Method Samsung Note is created...");
        }
    }
}
