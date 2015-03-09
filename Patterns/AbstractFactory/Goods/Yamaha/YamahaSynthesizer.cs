using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Goods.Yamaha
{
    class YamahaSynthesizer: IMusicalInstrument
    {
        public string Name
        {
            get { return "Yamaha DX-7"; }
        }
    }
}
