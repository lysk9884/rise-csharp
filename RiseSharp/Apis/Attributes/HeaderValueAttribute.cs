using System;
namespace RiseSharp.Apis.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class HeaderValueAttribute : Attribute
    {
		public string Name { get; set; }
		public object Default { get; set; }
    }
}
