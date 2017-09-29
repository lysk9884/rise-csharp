using System.Collections.Generic;
using System.Reflection;
using RiseSharp.Models;
using Newtonsoft.Json;
using RiseSharp.Apis.Attributes;

namespace RiseSharp.Apis.Requests.Base
{
	public abstract class BaseApiRequest
	{
		protected readonly List<string> QueryParams = new List<string>();

		[QueryParam(Name = "limit")]
		public int? Limit { get; set; }

		[QueryParam(Name = "offset")]
		public int? Offset { get; set; }

		[QueryParam(Name = "orderBy")]
		public string OrderBy { get; set; }

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}

		public virtual string ToQuery()
		{
            var propCollection = GetType().GetRuntimeProperties();

			foreach (PropertyInfo property in propCollection)
			{
				foreach (var attribute in property.GetCustomAttributes(true))
				{
					var attr = attribute as QueryParamAttribute;
					if (attr != null)
					{
						var val = property.GetValue(this);
						if (val != null)
							QueryParams.Add($"{attr.Name}={val}");
					}
				}
			}

			return string.Join("&", QueryParams.ToArray());
		}

        public virtual Dictionary<string, string> ToKeyValue()
		{
			var propCollection = GetType().GetRuntimeProperties();

            Dictionary<string, string> result = new Dictionary<string, string>();

			foreach (PropertyInfo property in propCollection)
			{
				foreach (var attribute in property.GetCustomAttributes(true))
				{
					var attr = attribute as QueryParamAttribute;
					if (attr != null)
					{
						var val = property.GetValue(this);
						if (val != null)
                            result.Add(attr.Name, val.ToString());
					}
				}
			}

            return result;
		}

		public IEnumerable<HeaderValue> GetHeaderValues()
		{
			var headerValues = new List<HeaderValue>();

			var propCollection = GetType().GetRuntimeProperties();

			foreach (PropertyInfo property in propCollection)
			{
				foreach (var attribute in property.GetCustomAttributes(true))
				{
					var attr = attribute as HeaderValueAttribute;
					if (attr != null)
					{
						var val = property.GetValue(this) ?? attr.Default;
						if (val != null)
						{
                            headerValues.Add(new HeaderValue(attr.Name, val.ToString()));
						}
					}
				}
			}

			return headerValues;
		}
	}
}
