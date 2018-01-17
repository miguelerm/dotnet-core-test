using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_test.Filters {
    public class HighLightToyotaFilterAttribute: Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var result = context.Result as ContentResult;
            result.Content = result.Content.Replace("Toyota", "****Toyota****", StringComparison.InvariantCultureIgnoreCase);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}