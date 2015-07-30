using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    /// <summary>
    /// Provides functionality to retrieve a text from source
    /// </summary>
    interface ITextRetriever
    {
        /// <summary>
        /// Get text from specified source
        /// </summary>
        /// <returns></returns>
        string GetText();
    }
}
