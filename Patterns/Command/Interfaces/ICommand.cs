using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Interfaces
{
    /// <summary>
    /// Represents a cancellable command
    /// </summary>
    interface ICommand
    {
        /// <summary>
        /// Execute action
        /// </summary>
        void Execute();

        /// <summary>
        /// Undo action
        /// </summary>
        void Unexecute();

        /// <summary>
        /// Indicates whether command supports unexecute operation
        /// </summary>
        bool IsCancellable { get; }
    }
}
