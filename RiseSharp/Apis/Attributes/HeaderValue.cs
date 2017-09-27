using System;
namespace RiseSharp.Apis.Attributes
{
	public class HeaderValue
	{
		public HeaderValue(string name, string value)
		{
			Name = name;
			Value = value;
		}

		public string Name { get; set; }
		public string Value { get; set; }
	}
}
