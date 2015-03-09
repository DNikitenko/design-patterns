using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Goods.Gibson
{
    class GibsonGuitar : IMusicalInstrument
    {
        public string Name
        {
            get { return "Fucking Gibson Mega Guitar"; }
        }
    }
}