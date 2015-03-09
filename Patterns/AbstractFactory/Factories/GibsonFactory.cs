using Patterns.AbstractFactory.Goods;
using Patterns.AbstractFactory.Goods.Gibson;
using Patterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Factories
{
    class GibsonFactory : IMusicalInstrumentFactory
    {
        public IMusicalInstrument CreateGuitar(int stringsNum)
        {
            return new GibsonGuitar();
        }

        public IMusicalInstrument CreateSynthesizer()
        {
            return new GibsonSynthesizer();
        }

        public IMusicalInstrument CreateViolin()
        {
            return new GibsonViolin();
        }
    }
}
