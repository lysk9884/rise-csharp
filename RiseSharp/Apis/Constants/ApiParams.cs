using System;
namespace RiseSharp.Apis.Constants
{
    public static class ApiParams
    {
		public const string Https = "https";
		public const string Http = "http";

		public const string DefaultHost = "wallet.rise.vision";
		public const string DefaultHostIp = "192.168.3.116";

		public const int DefaultPort = 5555;

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
