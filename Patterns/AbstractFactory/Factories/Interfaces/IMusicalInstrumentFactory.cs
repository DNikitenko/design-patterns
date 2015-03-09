using Patterns.AbstractFactory.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Interfaces
{
    /// <summary>
    /// Supports all necessary operations for musical instrument factories
    /// </summary>
    interface IMusicalInstrumentFactory
    {
        IMusicalInstrument CreateGuitar(int stringsNum);

        IMusicalInstrument CreateSynthesizer();

        IMusicalInstrument CreateViolin();
    }
}