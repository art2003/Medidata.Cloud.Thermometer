using System;
using System.Collections.Generic;
using Microsoft.Owin;

namespace Medidata.Cloud.Thermometer
{
    public class ActionRouteConfiguration : Dictionary<PathString, Func<IDictionary<string, object>, object>>
    {
    }
}