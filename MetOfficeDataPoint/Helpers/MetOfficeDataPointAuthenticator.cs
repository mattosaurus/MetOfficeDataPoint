using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetOfficeDataPoint.Helpers
{
    public class MetOfficeDataPointAuthenticator : AuthenticatorBase
    {
        public MetOfficeDataPointAuthenticator(string apiKey) : base(apiKey) { }

        protected override ValueTask<Parameter> GetAuthenticationParameter(string apiKey)
            => new(new QueryParameter("key", apiKey));
    }
}
