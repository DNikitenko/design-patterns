using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Builders
{
    /// <summary>
    /// Provides an interface for WebRequest object configuration and to getting its object
    /// </summary>
    class WebRequestBuilder
    {
        /// <summary>
        /// Uses agent for some version of Chrome browser
        /// </summary>
        protected const string DEFAULT_USER_AGENT = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/35.0.1916.153 Safari/537.36";

        /// <summary>
        /// HttpWebRequest to build and return after
        /// </summary>
        protected readonly HttpWebRequest RequestObject;

        /// <summary>
        /// Set protocol (GET, POST, etc.)
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public virtual WebRequestBuilder ConfigureMethod()
        {
            return this;
        }

        /// <summary>
        /// Set UserAgent string. In base WebRequestBuilder Chrome one is set
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        public virtual WebRequestBuilder ConfigureUserAgent()
        {
            RequestObject.UserAgent = DEFAULT_USER_AGENT;
            return this;
        }

        /// <summary>
        /// Emulates browser cookies
        /// </summary>
        /// <param name="cookies"></param>
        /// <returns></returns>
        public virtual WebRequestBuilder ConfigureCookies(CookieContainer cookies)
        {
            RequestObject.CookieContainer = cookies;
            return this;
        }

        /// <summary>
        /// When overriding in derived class, may write request options into its stream
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public virtual WebRequestBuilder ConfigureRequestOptions(string options)
        {
            return this;
        }

        /// <summary>
        /// Perform request and get a result string
        /// </summary>
        /// <returns></returns>
        public virtual string GetRequestResult()
        {
            using (var response = RequestObject.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var streamReader = new StreamReader(stream, Encoding.UTF8))
            {
                return streamReader.ReadToEnd();
            }
        }

        /// <summary>
        /// Creates HTTP request object from specified URL
        /// </summary>
        /// <param name="url">URL should start with http:// or https:// prefix</param>
        protected WebRequestBuilder(string url)
        {
            RequestObject = WebRequest.CreateHttp(url);
        }
    }
}
