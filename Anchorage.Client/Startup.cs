using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Timers;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace Anchorage.Client
{

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
            app.UseLocalTimeZone();
        }
    }

    public class Globals
    {
        public static Timer AutoReloadTimer
        {
            get
            {
                return _autoReloadTimer;
            }
            set
            {
                if (_autoReloadTimer != null)
                {
                    _autoReloadTimer.Dispose();
                }
                _autoReloadTimer = value;
            }
        }
        private static Timer _autoReloadTimer;
    }

}
