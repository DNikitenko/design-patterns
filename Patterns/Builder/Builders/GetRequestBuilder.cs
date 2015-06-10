using Patterns.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.Builders
{
    /// <summary>
    /// Represents standard GET request
    /// </summary>
    class GetRequestBuilder : WebRequestBuilder
    {
        /// <summary>
        /// Set GET method for request
        /// </summary>
        /// <returns></returns>
        public override WebRequestBuilder ConfigureMethod()
        {
            RequestObject.Method = "GET";
            return this;
        }

        public GetRequestBuilder(string url) : base(url) { }
    }
}