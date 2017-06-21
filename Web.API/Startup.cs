using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Web.TORCHx.Core.BLL.Membership;
using Web.TORCHx.Core.BLL.Data;
using Web.TORCHx.Core.Web.Common;

namespace Web.TORCHx.Core.Web.API
{
    public partial class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
			//Configuration
            services.AddSingleton<IConfiguration>(Configuration);
			services.Configure<TokenServiceOptions>(this.Configuration.GetSection(nameof(TokenServiceOptions)));
			services.Configure<CookieServiceOptions>(this.Configuration.GetSection(nameof(CookieServiceOptions)));

			//Built-in classes
			services.AddDbContext<DatabaseContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));
			services.AddDbContext<MembershipContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddMvc();

			//Custom classes
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<ITokenService, TokenService>();
			services.AddScoped<ICookieService, CookieService>();
			services.AddScoped<IJsonWriter, JsonWriter>();
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //Configure logging
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

			//Get services from DI container
			var tokenService = app.ApplicationServices.GetService<ITokenService>();
			var cookieService = app.ApplicationServices.GetService<ICookieService>();
			var jsonWriter = app.ApplicationServices.GetService<IJsonWriter>();

			//Use cookie authentication if cookie present
			app.UseWhen(context => context.Request.Cookies.ContainsKey(cookieService.CookieName()), appBuilder => {
                appBuilder.UseCookieAuthentication(cookieService.CookieAuthenticationOptions());
            });

            //Use bearer authentication if cookie not present
			app.UseWhen(context => !context.Request.Cookies.ContainsKey(cookieService.CookieName()), appBuilder => {
                appBuilder.UseJwtBearerAuthentication(tokenService.JwtBearerOptions());
            });

			//Cannot use this. Does not catch exceptions thrown by custom middleware.
			//app.UseExceptionHandler("/error");

			//Cannot use this. Does not catch 404's via POST.
			//app.UseStatusCodePagesWithReExecute("/error/{0}");

			app.UseStatusCodePages(async context => {
				var code = (HttpStatusCode)context.HttpContext.Response.StatusCode;
				var response = new FailureResponse(code);
				await jsonWriter.WriteObject(context.HttpContext, response, code);
			});

			//Use other middleware
			app.UseMiddleware<ErrorMiddleware>();
			app.UseMiddleware<UserAgentMiddleware>();

			//Can't use conventional routing like in MVC: https://github.com/aspnet/Routing/issues/381
			app.UseMvc();
        }
    }
}
