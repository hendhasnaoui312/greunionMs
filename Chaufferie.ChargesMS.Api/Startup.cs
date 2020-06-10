using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Chaufferie.ChargeMS.Data.Context;
using Chaufferie.ChargesMS.Infra.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Polly;

namespace Chaufferie.ChargesMS.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("ang",
            //    builder =>
            //    {
            //        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            //    });
            //});

            services.AddDbContext<ChargesContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("ChargesConnection"));
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            services.AddAutoMapper(typeof(Startup));
            DependencyContainer.RegisterService(services);
            //services.AddHttpClient("ChaudiereMsClient", client =>
            //{
            //    client.BaseAddress = new Uri("http://192.168.160.74:31633/review-chaudiere/api/");

            //})
            //.AddTransientHttpErrorPolicy(x =>
            //    x.WaitAndRetryAsync(3, _ => TimeSpan.FromMilliseconds(300)));

     
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ContractMS Microservice V1");
            });
            app.UseHttpsRedirection();
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //app.UseCors("ang");
        }
    }
}
