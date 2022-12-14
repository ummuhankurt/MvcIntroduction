using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcIntroduction.Filters
{
    public class CustomFilter : Attribute, IActionFilter 
    {
        //Aksiyonun önündeki çalışacak kod bloğu.
        public void OnActionExecuting(ActionExecutingContext context)
        {
            int i = 10;
        }
        //Aksiyonun sonundaki çalışacak kod bloğu.
        public void OnActionExecuted(ActionExecutedContext context)
        {
            int i = 20;
        }
    }
}
