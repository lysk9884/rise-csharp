using System;
using NBitcoin.BouncyCastle.Math;
using RiseSharp.Models.Base;

namespace RiseSharp.Models
{
	public class Address : BaseObject
	{
		public Address()
		{
			KeyPair = new KeyPair();
		}
		public KeyPair KeyPair { get; set; }
		public BigInteger Id { get; set; }

		public string IdString => $"{Id}{Constants.AddressSuffix}";

	}
}
