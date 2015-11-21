using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    /// <summary>
    /// Supports writing to console
    /// </summary>
    class ConsoleTextWriter
    {
        string _currentText = String.Empty;

        /// <summary>
        /// Current text shown in console
        /// </summary>
        public string CurrentText { get { return _currentText; } }

        /// <summary>
        /// Write text to console
        /// </summary>
        /// <param name="text"></param>
        public void Write(string text)
        {
            _currentText = text;
            Console.WriteLine("Changing input to: " + text);
        }
    }
}
