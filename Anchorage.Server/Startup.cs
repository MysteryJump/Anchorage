using System;
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
            //services.Configure<MvcOptions>(options =>
            //{
            //    options.InputFormatters.Add(new )
            //})
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
            IsUsingLegacyMode = Configuration.GetValue<bool>("UseLegacymode");
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}"
                    );

            });
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
