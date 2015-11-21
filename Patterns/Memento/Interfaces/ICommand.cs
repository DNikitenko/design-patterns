using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    /// <summary>
    /// Represents a command that can be executed but cannot be undone
    /// </summary>
    interface ICommand
    {
        /// <summary>
        /// Perform command's related actions
        /// </summary>
        void Execute();
    }
}
