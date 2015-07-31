using Patterns.Builder.Builders;
using Patterns.Builder.RequestRunners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    /// <summary>
    /// Provides web page downloading functionality (Facade)
    /// </summary>
    static class DownloadManager
    {
        /// <summary>
        /// Web request builder
        /// </summary>
        static WebRequestBuilder _requestBuilder;

        /// <summary>
        /// Web request configurator
        /// </summary>
        static DefaultWebRequestManager _requestManager;

        /// <summary>
        /// Get web resource as a plain text
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static string GetText(string link)
        {
            //Copied from BuilderTest
            _requestBuilder = new GetRequestBuilder(link);
            _requestManager = new DefaultWebRequestManager(_requestBuilder);

            _requestManager.ConfigureRequest();
            return _requestBuilder.GetRequestResult();
        }
    }
}
