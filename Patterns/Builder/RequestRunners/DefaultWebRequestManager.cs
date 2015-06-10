using Patterns.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.RequestRunners
{
    /// <summary>
    /// Provides web request configurator
    /// </summary>
    class DefaultWebRequestManager
    {
        readonly WebRequestBuilder Builder;

        readonly string RequestData;

        public DefaultWebRequestManager(WebRequestBuilder builder, string requestData = null)
        {
            Builder = builder;
            RequestData = requestData;
        }

        /// <summary>
        /// Configure a web request using current builder
        /// </summary>
        public void ConfigureRequest()
        {
            Builder
                .ConfigureMethod()
                .ConfigureUserAgent()
                .ConfigureRequestOptions(RequestData)
                .ConfigureCookies(new CookieContainer());
        }
    }
}
