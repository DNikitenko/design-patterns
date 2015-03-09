using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Goods.Yamaha
{
    class YamahaGuitar : IMusicalInstrument
    {
        public string Name
        {
            get { return "Yamaha F310"; }
        }
    }
}
