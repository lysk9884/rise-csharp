using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RiseSharp.Apis.Attributes;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Requests.Base;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Base
{
    public class BaseApi
    {
		protected UriBuilder UriBuilder { get; private set; }
		protected HttpClient HttpClient { get; private set; }
        public Config NetworkConfig { get; private set; }

        public BaseApi()
        {
            NetworkConfig = new Config();
            InitApi();
        }

        public BaseApi(Config NetworkConfig)
		{
            this.NetworkConfig = NetworkConfig;
			InitApi();
		}

        private void InitApi(){
			HttpClient = new HttpClient();
            HttpClient.Timeout = TimeSpan.FromMilliseconds(5000);

            UriBuilder = new UriBuilder
			{
				Host = NetworkConfig.Host,
				Scheme = NetworkConfig.Scheme,
			};

            if (NetworkConfig.Port.HasValue)
            {
                UriBuilder.Port = NetworkConfig.Port.Value;
            }
        }

        protected virtual void ResetBuilder()
        {
            ClearPath();
            ClearQuery();
        }

		protected void ClearPath()
		{
			UriBuilder.Path = string.Empty;
		}

		protected void ClearQuery()
		{
			UriBuilder.Query = string.Empty;
		}

        protected Task<T> GetSimpleJsonAsync<T>(string Path) where T : BaseApiResponse
		{
			ResetBuilder();
			UriBuilder.Path = Path;
			return HttpClient.GetJsonAsync<T>(UriBuilder.ToString());
		}

        protected Task<T> GetSimpleJsonAsync<T,R>(R Request, string Path) 
            where R : BaseApiRequest
        {
			ResetBuilder();
            UriBuilder.Path = Path;
			UriBuilder.Query = Request.ToQuery();

			return HttpClient.GetJsonAsync<T>(UriBuilder.ToString());
        }

        protected Task<T> PutSimpleJsonAsync<T, R>(R Request, string Path)
            where R : BaseApiRequest
        {
			ResetBuilder();
            UriBuilder.Path = Path;

            return HttpClient.PutJsonAsync<R, T>(UriBuilder.ToString(), Request);
        }

		protected Task<T> PostSimpleJsonAsync<T, R>(R Request, string Path) 
            where R : BaseApiRequest
		{
			ResetBuilder();
			UriBuilder.Path = Path;

            return HttpClient.PostJsonAsync<R, T>(UriBuilder.ToString(), Request);
		}
	}
}
