﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Anchorage.Server.Controllers;
using Anchorage.Server.Models;
using Microsoft.AspNetCore.Blazor.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpOverrides;
using System.Reflection;
using System.IO;
//using Swashbuckle.AspNetCore.Swagger;

namespace Anchorage.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public static bool IsUsingLegacyMode { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddProgressiveWebApp();
            services.AddResponseCompression(options =>
            {
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                {
                    MediaTypeNames.Application.Octet,
                    WasmMediaTypeNames.Application.Wasm,
                });
            });
            services.AddMvc(options =>
            {
                options.OutputFormatters.Add(new ShiftJISTextOutputFormatter());
            });

            var serverType = (ServerType)Enum.ToObject(typeof(ServerType),int.Parse(Configuration.GetConnectionString("ServerType")));

            services.AddDbContextPool<MainContext>( 
                options => options.UseMySql(Configuration.GetConnectionString("MainContext"), 
                    mysqlOptions =>
                    {
                        mysqlOptions.ServerVersion(new Version(Configuration.GetConnectionString("ServerVersion")), serverType); 
                    }
            ));

            

            services.AddSwaggerDocument();
            // services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme);  
            //services.Configure<MvcOptions>(options =>
            //{
            //    options.InputFormatters.Add(new )
            //})
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("amiens", new Info { Title = "Amiens", Version = "v1",  });
            //    //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            //    //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            //    //c.IncludeXmlComments(xmlPath);
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            if (Configuration.GetValue<bool>("RestrictHTTPConnection"))
            {
                app.UseHttpsRedirection();
            }
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });
            IsUsingLegacyMode = Configuration.GetValue<bool>("UseLegacymode");
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}"
                    );

            });
            //app.UseSwagger();

            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Amiens API");
            //});
            app.UseStaticFiles();

            // Register the Swagger generator and the Swagger UI middlewares
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseBlazor<Client.Program>();
            
        }
    }

    //public class LegacyViewOutputFormatter : TextOutputFormatter
    //{
    //    public LegacyViewOutputFormatter()
    //    {
    //        SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/plain"));

    //        SupportedEncodings.Add(Encoding.GetEncoding("shift_jis"));
    //    }

    //    public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
    //    {
    //        context.
    //    }
    //}
}
