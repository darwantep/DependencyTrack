using DNTCaptcha.Core;
using Duende.IdentityServer.EntityFramework.DbContexts;
using HealthChecks.UI.Client;
using IdentityExpress.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.FeatureManagement;
using Rsk.Saml.Configuration;
using Rsk.Saml.IdentityProvider.Storage.EntityFramework.DbContexts;
using Rsk.WsFederation.Configuration;
using Rsk.WsFederation.EntityFramework.DbContexts;
using Serilog;
using System;


namespace Demo.IdSrv
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        
        public IWebHostEnvironment Environment { get; }

        public Startup(IWebHostEnvironment environment, IConfiguration configuration)
        {

        }

        public void ConfigureServices(IServiceCollection services)
        {
            
        }
    }
}
