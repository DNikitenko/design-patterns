using Patterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Classes
{
    class NiceAssGirlDecorator: IGirl
    {
        IGirl _girl;

        public NiceAssGirlDecorator(IGirl girl)
        {
            _girl = girl;
        }

        public void Talk()
        {
            _girl.Talk();
            Console.WriteLine("I'm hot and got a nice ass!");
        }
    }
}
