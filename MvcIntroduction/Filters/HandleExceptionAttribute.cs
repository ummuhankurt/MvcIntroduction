using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcIntroduction.Filters
{
    public class HandleExceptionAttribute : ExceptionFilterAttribute 
    {

        public string ViewName { get; set; } = "Error";
        public Type ExceptionType { get; set; } = null; // aldığımız hata türüne göre hareket etmemizi sağlayacak.
        //Olurda bir hata olursa ; result döndürüyoruz.
        public override void OnException(ExceptionContext context)
        {
            if (ExceptionType != null)
            {
                if (context.Exception.GetType() == ExceptionType) // gerçekleşen hata türü,attributeki hata türüyle aynı mı ?
                {
                    var result = new ViewResult { ViewName = ViewName };
                    var modelDataProvider = new EmptyModelMetadataProvider();
                    result.ViewData = new ViewDataDictionary(modelDataProvider, context.ModelState);
                    result.ViewData.Add("HandleException", context.Exception);
                    context.Result = result;
                    context.ExceptionHandled = true;
                }
            }   
        }

    }
}
