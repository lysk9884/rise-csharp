using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using RiseSharp.Apis.Requests.Base;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis
{
    public static class ApiUtils
    {
        public static async Task<T> GetJsonAsync<T>(this HttpClient client, string url)
		{
            var result = await client.GetAsync(url).ConfigureAwait(false);
             result.EnsureSuccessStatusCode();
             if (result.Content != null)
             {
                 var json = await result.Content.ReadAsStringAsync();
                 return JsonConvert.DeserializeObject<T>(json);
             }
			return default(T);
		}

        public static async Task PostJsonAsync<T>(this HttpClient client, string url, T req) where T : BaseApiRequest
		{
            var result = await client.PostAsync(url, new FormUrlEncodedContent(req.ToKeyValue())).ConfigureAwait(false);
			result.EnsureSuccessStatusCode();
		}

        public static async Task<T2> PostJsonAsync<T1, T2>(this HttpClient client, string url, T1 req) where T1 : BaseApiRequest
		{
            var result = await client.PostAsync(url, new FormUrlEncodedContent(req.ToKeyValue())).ConfigureAwait(false);
			result.EnsureSuccessStatusCode();
			if (result.Content != null)
			{
				var json = await result.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T2>(json);
			}
			return default(T2);
		}

		public static async Task PutJsonAsync<T>(this HttpClient client, string url, T req) where T : BaseApiRequest
		{
            var result = await client.PutAsync(url, new FormUrlEncodedContent(req.ToKeyValue())).ConfigureAwait(false);
			result.EnsureSuccessStatusCode();
		}

        public static async Task<T2> PutJsonAsync<T1, T2>(this HttpClient client, string url, T1 req) where T1 : BaseApiRequest
		{
            var result = await client.PutAsync(url, new FormUrlEncodedContent(req.ToKeyValue())).ConfigureAwait(false); // new StringContent(req.ToString(), Encoding.UTF8, "application/json")
			result.EnsureSuccessStatusCode();
			if (result.Content != null)
			{
				var json = await result.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<T2>(json);
			}
			return default(T2);
		}
	}
}
