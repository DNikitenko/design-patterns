using Patterns.Builder.Builders;
using Patterns.Builder.RequestRunners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    /// <summary>
    /// Supports web page contents retrieving
    /// </summary>
    class WebPageRetriever : ITextRetriever
    {
        /// <summary>
        /// Hyperlink for web page to download
        /// </summary>
        readonly string _hyperLink;

        /// <summary>
        /// Initializes new instance of WebPageRetriever for specified web page
        /// </summary>
        /// <param name="hyperLink"></param>
        public WebPageRetriever(string hyperLink)
        {
            _hyperLink = hyperLink;
        }

        /// <summary>
        /// Download specified web page as a plain text
        /// </summary>
        /// <returns></returns>
        public string GetText()
        {
            var getBuilder = new GetRequestBuilder(_hyperLink);
            var downloadManager = new DefaultWebRequestManager(getBuilder);

            downloadManager.ConfigureRequest();
            return getBuilder.GetRequestResult();
        }
    }
}
