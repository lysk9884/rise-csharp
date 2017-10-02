using System;
using RiseSharp.Apis.Constants;

namespace RiseSharp.Apis
{
    public class Config
    {
        public string Scheme { get; private set; }
        public string Host{ get; private set; }
        public int Port{ get; private set; }

        /// <summary>
        /// Default constructor with constant parameters
        /// </summary>
        public Config()
        {
			Scheme = ApiParams.Https;
		    Host = ApiParams.DefaultHostIp;
		    Port = ApiParams.DefaultPort;
        }

        public Config(string Scheme, string Host, int Port)
        {
            this.Scheme = !string.IsNullOrWhiteSpace(Scheme)? Scheme : ApiParams.Https;
            this.Host = !string.IsNullOrWhiteSpace(Host) ? Host : ApiParams.DefaultHostIp;
            this.Port = Port > 0 ? Port : ApiParams.DefaultPort;
        }
    }
}
