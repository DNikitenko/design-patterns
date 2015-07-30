using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    /// <summary>
    /// A factory for ITextRetriever implementors
    /// </summary>
    class TextRetrieverFactory
    {
        /// <summary>
        /// Create a retriever for specified file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static ITextRetriever CreateFileTextRetriever (string fileName)
        {
            return new FileTextRetriever(fileName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hyperLink"></param>
        /// <returns></returns>
        public static ITextRetriever CreateWebPageRetriever (string hyperLink)
        {
            return new WebPageRetriever(hyperLink);
        }
    }
}
