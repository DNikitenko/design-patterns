using Patterns.AbstractFactory.Goods;
using Patterns.AbstractFactory.Goods.Korg;
using Patterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Factories
{
    class KorgFactory : IMusicalInstrumentFactory
    {
        public IMusicalInstrument CreateGuitar(int stringsNum)
        {
            throw new NotSupportedException("Korg doesn't produce guitars");
        }

        public IMusicalInstrument CreateSynthesizer()
        {
            return new KorgSynthesizer();
        }

        public IMusicalInstrument CreateViolin()
        {
            throw new NotSupportedException("Korg doesn't produce violins");
        }
    }
}
