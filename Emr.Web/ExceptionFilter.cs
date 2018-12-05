using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Shelter.Web.Extensions
{
    public class ExceptionFilter : IExceptionFilter
    {
        /// <inheritdoc />
        public void OnException(ExceptionContext context)
        {
            var message = new
            {  IsError = true,
               ErrorText = context.Exception.ToString()
            };
            context.HttpContext.Response.StatusCode = 500;
            context.Result = new JsonResult(message);
        }
    }
}
