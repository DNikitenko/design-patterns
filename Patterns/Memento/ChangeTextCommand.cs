using Patterns.Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    /// <summary>
    /// A command that is able to write some text to console and backup current state
    /// </summary>
    class ChangeTextCommand : ICommand
    {
        private readonly IBackupHolder _stateManager;
        private readonly ConsoleTextWriter _textWriter;
        private readonly string _text;
        private readonly bool _needBackup;

        private ChangeTextCommand(ConsoleTextWriter textWriter)
        {
            _textWriter = textWriter;
        }

        public ChangeTextCommand(IBackupHolder stateManager, ConsoleTextWriter textWriter, string text)
            : this(textWriter)
        {
            _stateManager = stateManager;
            _text = text;
            _needBackup = true;
        }

        public ChangeTextCommand(IStringChangeMemento recoverState, ConsoleTextWriter textWriter)
            : this(textWriter)
        {
            _text = (recoverState as IMementoForOwner).CurrentText;
            _needBackup = false;
        }

        public void Execute()
        {
            if (_needBackup)
            {
                var state = new StringMemento(_textWriter.CurrentText);
                _stateManager.BackupState(state);
            }

            _textWriter.Write(_text);
        }
    }
}
