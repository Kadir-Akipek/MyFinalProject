using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions //Extension metod yazabilmemiz için class'ımızın static olması gerekir
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services,
            ICoreModule[] modules)
        {
            foreach (var module in modules) //modüllerdeki her bir modül için modülü yükle
            {
               module.Load(services); 
            }

            return ServiceTool.Create(services);
        }
    }
}
