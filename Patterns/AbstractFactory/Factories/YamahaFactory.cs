using Patterns.AbstractFactory.Goods;
using Patterns.AbstractFactory.Goods.Yamaha;
using Patterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Factories
{
    class YamahaFactory : IMusicalInstrumentFactory
    {
        public IMusicalInstrument CreateGuitar(int stringsNum)
        {
            return new YamahaGuitar();
        }

        public IMusicalInstrument CreateSynthesizer()
        {
            return new YamahaSynthesizer();
        }

        public IMusicalInstrument CreateViolin()
        {
            return new YamahaViolin();
        }
    }
}
