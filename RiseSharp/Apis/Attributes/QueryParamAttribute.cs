using System;
namespace RiseSharp.Apis.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryParamAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
