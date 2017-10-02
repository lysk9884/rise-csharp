using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Headers;

namespace RiseSharp.Apis.Base
{
    public class BaseTransportApi : BaseApi
    {
        IEnumerable<HeaderValue> headerValues;

        public BaseTransportApi() : base() { }

        public BaseTransportApi(Config NetworkConfig) : base(NetworkConfig) { }

        protected new Task<T> GetSimpleJsonAsync<T, R>(R Request, string Path)
            where R : TransportHeaders
        {
            ResetBuilder();
            UriBuilder.Path = Path;
            AddHeaders(Request.GetHeaderValues());
            return HttpClient.GetJsonAsync<T>(UriBuilder.ToString());
        }

        protected new Task<T> PostSimpleJsonAsync<T, R>(R Request, string Path)
            where R : TransportHeaders
        {
            ResetBuilder();
            UriBuilder.Path = Path;
            UriBuilder.Query = Request.ToQuery();
            AddHeaders(Request.GetHeaderValues());
            return HttpClient.PostJsonAsync<R, T>(UriBuilder.ToString(), Request);
        }

        protected override void ResetBuilder()
        {
            base.ResetBuilder();
            ResetHeaders();
        }

        protected void AddHeaders(IEnumerable<HeaderValue> headerValues)
        {
            this.headerValues = headerValues;

            foreach (var headerValue in this.headerValues)
            {
                HttpClient.DefaultRequestHeaders.Add(headerValue.Name, headerValue.Value);
            }
        }

        protected void ResetHeaders()
        {
            if (headerValues != null)
            {
                foreach (var headerValue in headerValues)
                {
                    if (HttpClient.DefaultRequestHeaders.Contains(headerValue.Name))
                        HttpClient.DefaultRequestHeaders.Remove(headerValue.Name);
                }
            }
        }
    }
}
