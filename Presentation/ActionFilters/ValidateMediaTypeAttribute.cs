using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ActionFilters
{
    public class ValidateMediaTypeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var accepHeaderPresent = context.HttpContext.Request.Headers.ContainsKey("Accept");

            if (!accepHeaderPresent)
            {
                context.Result = new BadRequestObjectResult($"Accept header not present!");
                return;
            }

            var mediaType = context.HttpContext.Request.Headers["Accept"].FirstOrDefault();

            if(MediaTypeHeaderValue.TryParse(mediaType, out MediaTypeHeaderValue? outMediaType))
            {
                context.Result = new BadRequestObjectResult($"Media type not supported! {outMediaType}");
                return;
            }

            context.HttpContext.Items.Add("AcceptHeader", outMediaType);
        }
    }
}
