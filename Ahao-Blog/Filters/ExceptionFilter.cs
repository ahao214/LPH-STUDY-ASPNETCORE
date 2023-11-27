using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ahao_Blog.Filters
{
    /// <summary>
    /// 异常过滤器
    /// </summary>
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger<ExceptionFilter> logger;

        public ExceptionFilter(ILogger<ExceptionFilter> log)
        {
            logger = log;
        }

        public override void OnException(ExceptionContext context)
        {
            var ex = context.Exception;

            if (ex is BusinessException exceptions)
            {
                context.Result = new OkObjectResult(new HttpResult(exceptions.Code, exceptions.Message));
            }
            else
            {
                context.Result = new OkObjectResult(new HttpResult(500, ex.Message));
            }
            context.ExceptionHandled = true;
        }
    }
}
