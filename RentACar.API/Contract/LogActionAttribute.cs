using System.Reflection;
using log4net;
using ActionExecutingContext = Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext;
using ActionExecutedContext = Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext;
using ActionFilterAttribute = Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute;
using Volo.Abp.Users;

namespace RentACar.API.Contract
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class Log4NetActionFilterAttribute : ActionFilterAttribute
    {
        private readonly ILog _logger;
        private readonly ICurrentUser _current;


        public Log4NetActionFilterAttribute(ICurrentUser current)
        {
            _current = current;
        }


        public Log4NetActionFilterAttribute()
        {
            _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string? userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            //log4net.GlobalContext.Properties["userName"] = _current.UserName;
            log4net.GlobalContext.Properties["userName"] = userName;

            //string currentUser = _current.UserName;


            if (userName == null)
            {
                _logger.Error("Error occured");
            }

            _logger.Info($"Executing {context.ActionDescriptor.DisplayName}, by {userName}");
            _logger.Info($"User '{userName}' is performing an action.");
            base.OnActionExecuting(context);
        }   

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null)
            {
                _logger.Error("An error occurred:", context.Exception);
            }
            _logger.Info($"Executed {context.ActionDescriptor.DisplayName}");
            base.OnActionExecuted(context);
        }

    }
}

