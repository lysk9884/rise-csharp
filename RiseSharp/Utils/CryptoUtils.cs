using NBitcoin;

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
    }
}
