using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public static class ServiceTool//Bunun sayesinde microsofttta olan Ihttp lere   builder.RegisterType<AuthManager>().As<IAuthService>(); bunu vere biliyorum CoreModulde(Core.DependencyResolvers)
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
