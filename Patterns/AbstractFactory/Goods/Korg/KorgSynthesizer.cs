using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Goods.Korg
{
    class KorgSynthesizer : IMusicalInstrument
    {
        public string Name
        {
            get { return "Korg PS60"; }
        }
    }
}
