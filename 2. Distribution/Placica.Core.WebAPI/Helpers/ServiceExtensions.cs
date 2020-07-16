using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Placica.Core.WebAPI.Helpers
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }

        public static IServiceCollection AddTokenAuthentication(this IServiceCollection services, IConfiguration config)  
        {  
            var secret = config.GetSection("JwtConfig").GetSection("secret").Value;  
  
            var key = Encoding.ASCII.GetBytes(secret);  
            services.AddAuthentication(x =>  
            {  
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;  
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;  
            })  
            .AddJwtBearer(x =>  
            {  
                x.TokenValidationParameters = new TokenValidationParameters  
                {  
                    IssuerSigningKey = new SymmetricSecurityKey(key), 
                    ValidateIssuer = false,  
                    ValidateAudience = false, 
                    //ValidateIssuer = true,  
                    //ValidateAudience = true,  
                    //ValidIssuer = "localhost",  
                    //ValidAudience = "localhost"  
                };  
            });  
  
            return services;  
        }  

        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}