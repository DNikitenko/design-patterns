using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    /// <summary>
    /// Supports viewing text from different sources
    /// </summary>
    class TextViewer
    {
        /// <summary>
        /// Adapter for retrieving a text from specified source
        /// </summary>
        readonly ITextRetriever _textRetriever;

        /// <summary>
        /// Initializes new instance of TextViewer using specified ITextRetriever object
        /// </summary>
        /// <param name="textRetriever"></param>
        public TextViewer(ITextRetriever textRetriever)
        {
            _textRetriever = textRetriever;
        }

        /// <summary>
        /// Print retrieved text out to console
        /// </summary>
        public void ShowText()
        {
            var text = _textRetriever.GetText();
            Console.WriteLine(text);
        }
    }
}
