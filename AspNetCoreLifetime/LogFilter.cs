using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNetCoreLifetime
{
    public class LogFilter:IActionFilter
    {
        private readonly ILogger<LogFilter> _logger;

        public LogFilter(ILogger<LogFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation($"Action:{context.ActionDescriptor.DisplayName} 执行完毕");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"当前执行：{context.ActionDescriptor.DisplayName}");
        }
    }
}
