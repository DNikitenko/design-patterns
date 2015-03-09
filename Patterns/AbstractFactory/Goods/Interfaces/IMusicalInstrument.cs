using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Goods
{
    /// <summary>
    /// Represents a musical instrument
    /// </summary>
    interface IMusicalInstrument
    {
        /// <summary>
        /// Instrument name
        /// </summary>
        string Name { get; }
    }
}
