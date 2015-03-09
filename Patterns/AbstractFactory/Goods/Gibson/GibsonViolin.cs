using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Goods.Gibson
{
    class GibsonViolin : IMusicalInstrument
    {
        public string Name
        {
            get { return "Gibson Violin"; }
        }
    }
}
