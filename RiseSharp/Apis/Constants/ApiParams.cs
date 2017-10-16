using System;
namespace RiseSharp.Apis.Constants
{
    public static class ApiParams
    {
		public const string Https = "https";
		public const string Http = "http";

		public const string DefaultHost = "twallet.rise.vision";
        public const string DefaultHostIp = "195.181.244.189";

		public const int DefaultPort = 80;

		public const bool UseHttps = true;

        public static string DefaultScheme {
            get
            {
                #pragma warning disable RECS0110
                return UseHttps ? Https : Http;
                #pragma warning restore RECS0110
            }
        }
    }
}
