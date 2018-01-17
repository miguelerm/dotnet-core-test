using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace mvc_test.Constraints {

    public class MakeRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var make = values[routeKey] as string;
            return string.Compare(make, "toyota", ignoreCase: true) == 0;
        }
    }

}

