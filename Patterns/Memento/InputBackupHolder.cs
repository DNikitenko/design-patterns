using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    /// <summary>
    /// Supports backup and restore for input
    /// </summary>
    class InputBackupHolder : IBackupHolder
    {
        /// <summary>
        /// Checkpoints stack; supports one-by-one restoring process
        /// </summary>
        private readonly Stack<IStringChangeMemento> _backups = new Stack<IStringChangeMemento>();

        /// <summary>
        /// Hiding constructor to avoid direct class instance creation
        /// </summary>
        private InputBackupHolder() { }

        /// <summary>
        /// Lazy initializer of singleton object
        /// </summary>
        static Lazy<InputBackupHolder> _lazyInstance = new Lazy<InputBackupHolder>(() => new InputBackupHolder());

        /// <summary>
        /// Get InputBackupHolder object instance
        /// </summary>
        public static InputBackupHolder Instance
        {
            get
            {
                return _lazyInstance.Value;
            }
        }

        /// <summary>
        /// Baclup speciried state
        /// </summary>
        /// <param name="state"></param>
        public void BackupState(IStringChangeMemento state)
        {
            _backups.Push(state);
        }

        /// <summary>
        /// Restore last saved state
        /// </summary>
        /// <returns></returns>
        public IStringChangeMemento RestoreState()
        {
            if (_backups.Count == 0)
                throw new InvalidOperationException("No backups available");

            return _backups.Pop();
        }

        /// <summary>
        /// Whether manager has avaivalbe checkpoints
        /// </summary>
        public bool CanRestore
        {
            get { return _backups.Count > 0; }
        }
    }
}
