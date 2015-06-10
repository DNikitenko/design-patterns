using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Patterns.Builder.Builders
{
    /// <summary>
    /// Represents POST request
    /// </summary>
    class PostRequestBuilder : WebRequestBuilder
    {
        /// <summary>
        /// Set GET method for request
        /// </summary>
        /// <returns></returns>
        public override WebRequestBuilder ConfigureMethod()
        {
            RequestObject.Method = "POST";
            return this;
        }

        /// <summary>
        /// Set POST data
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public override WebRequestBuilder ConfigureRequestOptions(string options)
        {
            var data = HttpUtility.UrlEncodeToBytes(options);
            RequestObject.ContentLength = data.Length;
            RequestObject.ContentType = "application/x-www-form-urlencoded";

            using (var requestStream = RequestObject.GetRequestStream())
            {
                requestStream.Write(data, 0, data.Length);
            }

            return this;
        }

        public PostRequestBuilder(string url) : base(url) { }
    }
}
