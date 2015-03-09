using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Goods.Gibson
{
    class GibsonSynthesizer : IMusicalInstrument
    {
        public string Name
        {
            get { return "Oberheim Matrix-1000"; }
        }
    }
}
