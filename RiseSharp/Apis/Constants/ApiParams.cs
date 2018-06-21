namespace RiseSharp.Apis.Constants
{
    public static class ApiParams
    {
        public const string Https = "https";
        public const string Http = "http";

        public const string DefaultHost = "testnode1.rise.vision";
        public const string DefaultHostIp = "194.135.95.105";

        public const int DefaultPort = 5566;

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