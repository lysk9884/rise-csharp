using System;
using RiseSharp.Apis.Constants;

namespace RiseSharp.Apis
{
    public class Config
    {
        public string Scheme { get; private set; }
        public string Host{ get; private set; }
        public int? Port { get; private set; } = null;

        /// <summary>
        /// Default constructor with constant parameters
        /// </summary>
        public Config()
        {
            Scheme = ApiParams.DefaultScheme;
		    Host = ApiParams.DefaultHostIp;
		    Port = ApiParams.DefaultPort;
        }

        public Config(string Host, bool UseHttps, int? Port)
        {
            this.Scheme = UseHttps? ApiParams.Https: ApiParams.Http;
            this.Host = !string.IsNullOrWhiteSpace(Host) ? Host : ApiParams.DefaultHostIp;
            if (Port != null)
            {
                this.Port = Port > 0 ? Port : ApiParams.DefaultPort;
            }
        }
    }
}
