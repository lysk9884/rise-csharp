namespace RiseSharp.Apis.Constants
{
    public static class ApiParams
    {
        public const string Https = "https";
        public const string Http = "http";

        public const string DefaultHost = "51.15.193.40";
        public const string DefaultHostIp = "194.135.95.105";

        public const int DefaultPort = 8080;

        public const bool UseHttps = false;

        public static string DefaultScheme
        {
            get
            {
#pragma warning disable RECS0110
                return UseHttps ? Https : Http;
#pragma warning restore RECS0110
            }
        }
    }
}