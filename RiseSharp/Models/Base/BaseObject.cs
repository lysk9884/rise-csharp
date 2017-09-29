using System;
using Newtonsoft.Json;

namespace RiseSharp.Models.Base
{
    public abstract class BaseObject
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
