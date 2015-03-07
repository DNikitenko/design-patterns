using Patterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Classes
{
    class IntelligentGirlDecorator : IGirl
    {
        IGirl _girl;

        public IntelligentGirlDecorator(IGirl girl)
        {
            _girl = girl;
        }

        public void Talk()
        {
            _girl.Talk();
            Console.WriteLine("I'm able to speak an intelligent way");
        }
    }
}
