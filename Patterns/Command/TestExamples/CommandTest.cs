using Patterns.Command.Implementation;
using Patterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Patterns.Command.TestExamples
{
    class CommandTest : IPatternTest
    {
        List<ICommand> _commandList = new List<ICommand>();

        ICommand _currentCommand;

        ICommand GetCommand(string cmdText)
        {            
            ICommand command = null;

            if (cmdText.StartsWith("create_file ", StringComparison.InvariantCultureIgnoreCase))
            {
                var filePath = Regex.Match(cmdText, @"(?<=create_file\s+)[^\s].*").Value;
                command = new CreateFileCommand(filePath);
            }
            else if (cmdText.StartsWith("delete_file ", StringComparison.InvariantCultureIgnoreCase))
            {
                var filePath = Regex.Match(cmdText, @"(?<=delete_file\s+)[^\s].*").Value;
                command = new DeleteFileCommand(filePath);
            }
            else if (cmdText.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
            {
                command = new ExitCommand();
            }

            return command;
        }

        void AddCommandToList(ICommand command)
        {
            if (_commandList.Any() && _currentCommand != _commandList.Last())
            {
                var currentCommandIdx = _commandList.IndexOf(_currentCommand);
                _commandList = _commandList.Take(currentCommandIdx + 1).ToList();
            }

            _currentCommand = command;
            _commandList.Add(command);
        }

        void RedoCommand()
        {
            if (_commandList.Any() && _currentCommand != _commandList.Last())
            {
                var currentCommandIdx = _commandList.IndexOf(_currentCommand);
                var nextCommand = _commandList[currentCommandIdx + 1];
                nextCommand.Execute();
                _currentCommand = nextCommand;
            }
        }

        void UndoLastCommand()
        {
            if (_currentCommand != null && _currentCommand.IsCancellable)
            {
                _currentCommand.Unexecute();
                var currentCommandIdx = _commandList.IndexOf(_currentCommand);
                if (currentCommandIdx != 0)
                {
                    _currentCommand = _commandList[currentCommandIdx - 1];
                }
            }
        }

        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the command centre! Next commands are available:");
            Console.WriteLine("create_file [filename]");
            Console.WriteLine("delete_file [filename]");
            Console.WriteLine("exit");
            Console.WriteLine();
            Console.WriteLine("You can also enter \"redo\" or \"undo\"");            
            
            while (true)
            {
                Console.Write(">");
                var cmdText = Console.ReadLine();

                if (cmdText.Equals("undo", StringComparison.InvariantCultureIgnoreCase))
                {
                    UndoLastCommand();
                }
                else if (cmdText.Equals("redo", StringComparison.InvariantCultureIgnoreCase))
                {
                    RedoCommand();
                }
                else
                {
                    var command = GetCommand(cmdText);
                    if (command == null)
                    {
                        Console.WriteLine("Wrong command");
                        continue;
                    }

                    AddCommandToList(command);
                    command.Execute();
                }
            }
        }
    }
}
