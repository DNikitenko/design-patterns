using Patterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Classes
{
    class JazzGirlDecorator : IGirl
    {
        IGirl _girl;

        public JazzGirlDecorator(IGirl girl)
        {
            _girl = girl;
        }

        public void Talk()
        {
            _girl.Talk();
            Console.WriteLine("I do love jazz");
        }
    }
}
