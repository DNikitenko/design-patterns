using Patterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command.Implementation
{
    /// <summary>
    /// Represents a command to create a file
    /// </summary>
    class CreateFileCommand : ICommand
    {
        readonly string _filePath;

        /// <summary>
        /// Initializes a new instance of CreateFileCommand with specified file path 
        /// </summary>
        /// <param name="filePath"></param>
        public CreateFileCommand(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Create a file with sprecified name
        /// </summary>
        public void Execute()
        {
            var fs = File.Create(_filePath);
            fs.Dispose();
        }

        /// <summary>
        /// Delete previously created file
        /// </summary>
        public void Unexecute()
        {
            File.Delete(_filePath);
        }

        /// <summary>
        /// Indicates whether command is cancellable. Returns true
        /// </summary>
        public bool IsCancellable
        {
            get { return true; }
        }
    }
}
