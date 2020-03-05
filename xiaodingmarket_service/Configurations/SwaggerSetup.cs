using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xiaodingmarket_service.Configurations
{
    public static class SwaggerSetup
    {
        public static void AddSwaggerSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "二手市场",
                    Description = "技术栈：.net core3.1 , DDD，JWT, Swagger, autofac, automapper, redis",
                    Contact = new OpenApiContact { Name = "小鼎", Email = "contato@eduardopires.net.br", Url = new Uri("http://www.eduardopires.net.br") },
                    License = new OpenApiLicense() { Name = "小鼎", Url = new Uri("https://github.com/") }
                });
            });
        }

        public static void UseSwaggerSetup(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "xiaodingmarket");
                c.RoutePrefix = "";
            });
        }
    }
}
