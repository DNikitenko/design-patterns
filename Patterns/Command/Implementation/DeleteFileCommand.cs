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
    /// Represents a command to delete a file
    /// </summary>
    class DeleteFileCommand : ICommand
    {
        readonly string _filePath;

        /// <summary>
        /// Initializes a new instance of DeleteFileCommand with specified file path 
        /// </summary>
        /// <param name="filePath"></param>
        public DeleteFileCommand(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Delete a file with sprecified name
        /// </summary>
        public void Execute()
        {
            File.Delete(_filePath);
        }

        /// <summary>
        /// Delete previously created file
        /// </summary>
        public void Unexecute()
        {
            var fs = File.Create(_filePath);
            fs.Dispose();            
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
