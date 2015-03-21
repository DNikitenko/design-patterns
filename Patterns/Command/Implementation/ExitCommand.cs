using Patterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Implementation
{
    /// <summary>
    /// Represents a command to exit application
    /// </summary>
    class ExitCommand : ICommand
    {
        /// <summary>
        /// Terminates an application
        /// </summary>
        public void Execute()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Npt supported
        /// </summary>
        public void Unexecute()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Whether a command can be cancelled; return false
        /// </summary>
        public bool IsCancellable
        {
            get { return false; }
        }
    }
}
