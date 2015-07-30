using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    /// <summary>
    /// Supports file contents retrieving
    /// </summary>
    class FileTextRetriever : ITextRetriever
    {
        /// <summary>
        /// Name of file to read
        /// </summary>
        readonly string _fileName;

        /// <summary>
        /// Initializes a new instance of FileTextRetriever object for specified file
        /// </summary>
        /// <param name="fileName"></param>
        public FileTextRetriever(string fileName)
        {
            _fileName = fileName;
        }

        /// <summary>
        /// Retrieve file contents
        /// </summary>
        /// <returns></returns>
        public string GetText()
        {
            using (var fileStream = new FileStream(_fileName, FileMode.Open))
            using (var streamReader = new StreamReader(fileStream))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
