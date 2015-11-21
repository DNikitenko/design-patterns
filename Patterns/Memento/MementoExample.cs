using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    class MementoExample : IPatternTest
    {
        public void Run()
        {
            var backupManager = InputBackupHolder.Instance;
            var textWriter = new ConsoleTextWriter();

            var commands = new[]
            {
                new ChangeTextCommand(backupManager, textWriter, "ololo"),
                new ChangeTextCommand(backupManager, textWriter, "bololo"),
                new ChangeTextCommand(backupManager, textWriter, "trololo")
            };

            foreach (var command in commands)
            {
                command.Execute();
            }

            while (backupManager.CanRestore)
            {
                var backupState = backupManager.RestoreState();
                var restoreCommand = new ChangeTextCommand(backupState, textWriter);
                restoreCommand.Execute();
            }

            Console.ReadLine();
        }
    }
}
