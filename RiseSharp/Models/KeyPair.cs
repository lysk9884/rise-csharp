using System;
using System.Text;
using RiseSharp.Utils;

namespace RiseSharp.Models
{
    public class KeyPair
    {
        public byte[] PublicKey { get; set; }

        public byte[] PrivateKey { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("Public Key : {0}", PublicKey != null ? PublicKey.ToHex() : "");
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("Private Key : {0}", PrivateKey != null ? PrivateKey.ToHex() : "");
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}
