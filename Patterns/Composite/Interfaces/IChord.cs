using Patterns.Composite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite.Interfaces
{
    /// <summary>
    /// Gives a basic access to chord's notes collection
    /// </summary>
    interface IChord
    {
        void Add(ISound note);
    }
}
