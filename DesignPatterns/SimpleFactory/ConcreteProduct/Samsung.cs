﻿using DesignPatterns.SimpleFactory.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory.ConcreteProduct
{
    internal class Samsung : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung Mobile....");
        }
    }
}