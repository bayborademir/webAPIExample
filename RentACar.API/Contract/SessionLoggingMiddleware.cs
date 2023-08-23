using System;
using log4net;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Users;

namespace RentACar.API.Contract
{
    //public class SessionLoggingMiddleware : IMiddleware, ITransientDependency
    //{
    //    private readonly IAbpSession _session;

    //    public SessionLoggingMiddleware(IAbpSession session)
    //    {
    //        _session = session;
    //    }

    //    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    //    {
    //        LogicalThreadContext.Properties["userid"] = _session.UserId;
    //        LogicalThreadContext.Properties["tenantid"] = _session.TenantId;
    //        await next(context);
    //    }
    //}


    public class MyService : ITransientDependency
    {
        private readonly ICurrentUser _currentUser;

        public MyService(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        public void Foo()
        {
            Guid? userId = _currentUser.Id;
        }
    }

}

