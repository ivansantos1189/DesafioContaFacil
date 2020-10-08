//using ContaFacil.Core.DomainObjects;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Text;

//namespace ContaFacil.WebAPI.Core.Exception
//{
//    public class CustomExceptionFilter : IExceptionFilter
//    {
//        public void OnException(ExceptionContext context)
//        {
//            HttpStatusCode status = HttpStatusCode.InternalServerError;
//            var message = new { status = "Error", errors = new string[0], result = false };


//            var contextException = context.Exception;
//            var baseException = contextException.GetBaseException();

//            if (contextException.GetType().IsSubclassOf(typeof(DomainException)))
//            {
//                var exception = ((DomainException)context.Exception);
//                status = HttpStatusCode.OK
//                result.errors[0] = exception.Message;
//            }



//            HttpResponse response = context.HttpContext.Response;

//            response.StatusCode = (int)status;
//            response.ContentType = "application/json";
//            context.Result = new JsonResult(result);
//        }
//    }
//}
