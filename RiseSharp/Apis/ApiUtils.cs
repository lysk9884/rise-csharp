using Newtonsoft.Json;
using RiseSharp.Apis.Requests.Base;
using RiseSharp.Utils;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

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
                return JsonConvert.DeserializeObject<T>(json, new ResponseJsonConverter<T>());
            }
            return default(T);
        }

        public static async Task PostJsonAsync<T>(this HttpClient client, string url, T req) where T : BaseApiRequest
        {
            //var content = new StringContent(req.ToString(), System.Text.Encoding.UTF8, "application/json");
            //var postBody = await content.ReadAsStringAsync();
            var urlContent = new FormUrlEncodedContent(req.ToKeyValue());
            var postBody = await urlContent.ReadAsStringAsync();

            var result = await client.PostAsync(url, urlContent).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }

        public static async Task<T2> PostJsonAsync<T1, T2>(this HttpClient client, string url, T1 req) where T1 : BaseApiRequest
        {
            var encodingType = System.Text.Encoding.UTF8;
            var contentType = "application/json";

            //var headerType = "application/x-www-form-urlencoded";
            var content = new StringContent(req.ToString(), encodingType, contentType);
            //var content = new FormUrlEncodedContent(req.ToKeyValue());
            content.Headers.ContentType = new MediaTypeHeaderValue(contentType);

            var result = await client.PostAsync(url, content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            if (result.Content != null)
            {
                var json = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T2>(json, new ResponseJsonConverter<T2>());
            }
            return default(T2);
        }

        public static async Task PutJsonAsync<T>(this HttpClient client, string url, T req) where T : BaseApiRequest
        {
            var content = new StringContent(req.ToString(), System.Text.Encoding.UTF8, "application/json");
            var postBody = await content.ReadAsStringAsync();

            var result = await client.PutAsync(url, content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
        }

        public static async Task<T2> PutJsonAsync<T1, T2>(this HttpClient client, string url, T1 req) where T1 : BaseApiRequest
        {
            var content = new StringContent(req.ToString(), System.Text.Encoding.UTF8, "application/json");
            var postBody = await content.ReadAsStringAsync();

            var result = await client.PutAsync(url, content).ConfigureAwait(false);
            result.EnsureSuccessStatusCode();
            if (result.Content != null)
            {
                var json = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T2>(json, new ResponseJsonConverter<T2>());
            }
            return default(T2);
        }
    }
}