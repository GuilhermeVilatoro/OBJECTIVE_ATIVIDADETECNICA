﻿using AtividadeTecnica.Infra.CrossCutting.IOC;
using AtividadeTecnica.WebApi.Configurations;
using AtividadeTecnica.WebApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace AtividadeTecnica.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                 .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                 .AddJsonOptions(option =>
                 {
                     var resolver = option.SerializerSettings.ContractResolver;
                     if (resolver != null)
                         (resolver as DefaultContractResolver).NamingStrategy = null;
                 });

            services.AddAutoMapperSetup();

            services.AddSwaggerDocumentation();

            InjectionDependencies.RegisterDependencies(services);

            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseHttpsRedirection();
            app.UseCors(options => options.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader());
            app.UseMvc();

            app.UseSwaggerDocumentation();
        }
    }
}