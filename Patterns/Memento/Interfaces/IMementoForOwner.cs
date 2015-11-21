using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    /// <summary>
    /// Stores current input
    /// </summary>
    interface IMementoForOwner
    {
        /// <summary>
        /// Saved console text
        /// </summary>
        string CurrentText { get; set; }
    }
}
