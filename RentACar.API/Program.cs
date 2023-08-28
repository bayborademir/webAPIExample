using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NLog.Web;
using RentACar.API;
using RentACar.Bussines.Abstract;
using RentACar.Bussines.Concrete;
using RentACar.DataAcces;
using RentACar.DataAcces.Abstract;
using RentACar.DataAcces.Concrete;
using RentACar.DataAcces.Models;
using System.Data;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

#region

builder.Services.AddScoped<ICarRepo, CarRepo>();
builder.Services.AddScoped<ICarService, CarManager>();

builder.Services.AddScoped<IEmployeeRepo,EmployeeRepo>();
builder.Services.AddScoped<IEmployeeService, EmployeeManager>();

builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();

builder.Services.AddScoped<IRentalRepo, RentalRepo>();
builder.Services.AddScoped<IRentalService, RentalManager>();

#endregion

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMemoryCache();
builder.Services.AddAutoMapper(typeof(MapperProfile));

builder.Logging.AddLog4Net();
XmlConfigurator.Configure(new FileInfo("log4net.config"));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddHttpContextAccessor();

var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

builder.Services.AddDbContext<RentAcarDbContext>();

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

builder.Services.AddIdentity<AspNetUser, AspNetRole>(opt =>
{
    opt.Password.RequireDigit = false;
    opt.Password.RequiredLength = 1;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireNonAlphanumeric = false;
    opt.User.RequireUniqueEmail = false;

}).AddEntityFrameworkStores<RentAcarDbContext>();


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = "http://localhost",
        ValidAudience = "http://localhost",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("deneme")),
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});

//--------------------------------------------------------------------------------------

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Use(async (httpContext, next) =>
{
    log4net.ThreadContext.Properties["ipAddress"] =
                                      httpContext?.Connection?.RemoteIpAddress;

    await next();
});


app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();


app.Run();


