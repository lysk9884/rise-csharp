using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RiseSharp.Apis.Responses.Base;

namespace RiseSharp.Apis.Responses
{
    [DataContract]
    public class GetDappCategoriesResponse : BaseApiResponse
    {
        [DataMember(Name = "categories")]
        public IDictionary<string, long> Categories;
    }
}
