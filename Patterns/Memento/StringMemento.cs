using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento.Interfaces
{
    /// <summary>
    /// Mementro for console text
    /// </summary>
    class StringMemento : IStringChangeMemento, IMementoForOwner
    {
        public StringMemento(string text)
        {
            CurrentText = text;
        }

        public string CurrentText { get; set; }
    }
}
