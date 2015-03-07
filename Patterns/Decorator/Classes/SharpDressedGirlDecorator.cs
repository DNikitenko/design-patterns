using Patterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Classes
{
    class SharpDressedGirlDecorator : IGirl
    {
        IGirl _girl;

        public SharpDressedGirlDecorator(IGirl girl)
        {
            _girl = girl;
        }

        public void Talk()
        {
            _girl.Talk();
            Console.WriteLine("Every man is crazy 'bout sharp dressed me");
        }
    }
}
