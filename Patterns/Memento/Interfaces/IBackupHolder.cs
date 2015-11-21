using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    /// <summary>
    /// An interface for all the possible backup managers
    /// </summary>
    interface IBackupHolder
    {
        /// <summary>
        /// Baclup specified state
        /// </summary>
        /// <param name="state"></param>
        void BackupState(IStringChangeMemento state);

        /// <summary>
        /// Restore last saved state
        /// </summary>
        /// <returns></returns>
        IStringChangeMemento RestoreState();

        /// <summary>
        /// True, if there are availabale checkpoints
        /// </summary>
        bool CanRestore { get; }
    }
}
