using System;
using System.Net.Http;
using System.Threading.Tasks;
using RiseSharp.Apis.Constants;
using RiseSharp.Apis.Requests.Base;

namespace RiseSharp.Apis.Base
{
    public class BaseApi
    {
		protected readonly UriBuilder UriBuilder;
		protected readonly HttpClient HttpClient;

        public BaseApi()
        {
			HttpClient = new HttpClient();

			UriBuilder = new UriBuilder
			{
				Host = ApiParams.DefaultHostIp,
				Scheme = ApiParams.Https,
				Port = ApiParams.DefaultPort
			};
        }

        protected void ResetBuilder()
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

		protected Task<T> GetSimpleJsonAsync<T>(string Path)
		{
			ResetBuilder();
			UriBuilder.Path = Path;
			return HttpClient.GetJsonAsync<T>(UriBuilder.ToString());
		}

        protected Task<T> GetSimpleJsonAsync<T,R>(R Request, string Path) where R : BaseApiRequest
        {
			ResetBuilder();
            UriBuilder.Path = Path;
			UriBuilder.Query = Request.ToQuery();
			return HttpClient.GetJsonAsync<T>(UriBuilder.ToString());
        }

        protected Task<T> PutSimpleJsonAsync<T, R>(R Request, string Path) where R : BaseApiRequest
        {
			ResetBuilder();
            UriBuilder.Path = Path;
			return HttpClient.PutJsonAsync<R, T>(UriBuilder.ToString(), Request);
        }

		protected Task<T> PostSimpleJsonAsync<T, R>(R Request, string Path) where R : BaseApiRequest
		{
			ResetBuilder();
			UriBuilder.Path = Path;
            return HttpClient.PostJsonAsync<R, T>(UriBuilder.ToString(), Request);
		}

	}
}
