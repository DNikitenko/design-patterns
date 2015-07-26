﻿using Patterns.AbstractFactory.TestExamples;
using Patterns.Bridge;
using Patterns.Builder.TestExamples;
using Patterns.Command.TestExamples;
using Patterns.Composite.TestExamples;
using Patterns.Decorator.TestExamples;
using Patterns.FactoryMethod.TestExamples;
using Patterns.Iterator.TestExamples;
using Patterns.Prototype;
using Patterns.Strategy.TestExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            new PrototypeTest().Run();
        }
    }
}
