using Patterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Classes
{
    /// <summary>
    /// Represents usual girl
    /// </summary>
    class BasicGirl : IGirl
    {
        public void Talk()
        {
            Console.WriteLine("I am just a girl");
        }
    }
}
