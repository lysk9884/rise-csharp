using System;
using System.Linq;
using System.Text;
using Chaos.NaCl;
using NBitcoin;
using NBitcoin.BouncyCastle.Math;
using NBitcoin.Crypto;
using NBitcoin.DataEncoders;
using RiseSharp.Models;

namespace RiseSharp.Utils
{
    public static class CryptoUtils
    {

		public static string GenerateSecret()
		{

			RandomUtils.Random = new UnsecureRandom();


			var mnemo = new Mnemonic(Wordlist.English, WordCount.Twelve);
			return mnemo.ToString();
		}

		public static BigInteger GetId(byte[] publicKey)
		{
			var pkHash = Hashes.SHA256(publicKey);
			var firstEight = pkHash.Take(8).Reverse().ToArray();
			return new BigInteger(1, firstEight);
		}

		public static Address GetAddress(string secret)
		{
			var keyPair = GetKeyPair(secret);
			var addressId = GetId(keyPair.PublicKey);

			return new Address
			{
				Id = addressId,
				KeyPair = keyPair
			};
		}

		public static KeyPair GetKeyPair(string secret)
		{
			var secretBytes = Encoding.UTF8.GetBytes(secret);
			var secretHash = Hashes.SHA256(secretBytes);
			byte[] publicKey, privateKey;
			Ed25519.KeyPairFromSeed(out publicKey, out privateKey, secretHash);
			return new KeyPair
			{
				PublicKey = publicKey,
				PrivateKey = privateKey
			};
		}

		public static byte[] Sign(byte[] message, byte[] privateKey)
		{
			var hash = Ed25519.Sign(message, privateKey);
			return hash;
		}

		public static bool Verify(byte[] signature, byte[] message, byte[] publicKey)
		{
			return Ed25519.Verify(signature, message, publicKey);
		}

		public static byte[] Sha256(byte[] data)
		{
			return Hashes.SHA256(data);
		}

		public static string ToHex(this byte[] bytes)
		{
			return BitConverter.ToString(bytes).Replace("-", "");
		}

		public static byte[] FromHex(this string str)
		{
			return Enumerable.Range(0, str.Length)
					.Where(x => x % 2 == 0)
					.Select(x => Convert.ToByte(str.Substring(x, 2), 16))
					.ToArray();
		}
		public static byte[] GetBytes(this long val)
		{
			byte[] bytes = BitConverter.GetBytes(val);
			if (BitConverter.IsLittleEndian)
				Array.Reverse(bytes);
			return bytes;
		}
		public static long GetLongBytes(this byte[] val)
		{
			long longValue = BitConverter.ToInt64(val, 0);
			return longValue;
		}
		public static byte[] GetBytes(this int val)
		{
			byte[] bytes = BitConverter.GetBytes(val);
			if (BitConverter.IsLittleEndian)
				Array.Reverse(bytes);
			return bytes;
		}

		public static int GetBytes(this byte[] val)
		{
			int intValue = BitConverter.ToInt32(val, 0);
			return intValue;
		}

		public static string ToBase64(this byte[] bytes)
		{
			return new Base64Encoder().EncodeData(bytes);
		}

		public static byte[] FromBase64(this string str)
		{
			return new Base64Encoder().DecodeData(str);
		}

		public static int ToUnixTimeInSeconds(this DateTime dateTime)
		{
			var dt = (dateTime.Kind != DateTimeKind.Utc) ? dateTime.ToUniversalTime() : dateTime;
			var epochTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			var seconds = (int)(dt - epochTime).TotalSeconds;
			return seconds;
		}

		public static DateTime FromUnixTimeSeconds(this int unixTimeInSeconds)
		{
			var epochTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return epochTime.AddSeconds(unixTimeInSeconds);
		}
    }
}
