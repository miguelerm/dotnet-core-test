using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_test.Filters {
    public class BadRequestfilterAttribute: Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Action Ejecutado");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}