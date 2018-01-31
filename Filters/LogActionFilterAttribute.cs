using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_test.Filters {
    public class LogActionFilterAttribute: Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Action Ejecutado");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //context.Result = new RedirectResult("http://www.google.com.gt");
            Debug.WriteLine("Ejecutando el action...");
        }
    }
}