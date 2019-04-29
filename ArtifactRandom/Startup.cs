using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ArtifactRandom
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }

    }
}
