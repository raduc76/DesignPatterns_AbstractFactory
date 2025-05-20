using AbstractFactory.Core.Drivers;
using AbstractFactory.Core.Factories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Helpers
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDriverFactory(this IServiceCollection services)
        {
            services.AddSingleton<IDriverFactory, EUDriverFactory>();
        }

        public static void AddDriverFactoryWithDI(this IServiceCollection services)
        {
            services.AddSingleton<IDriverFactory, EUDriverFactoryWithDI>();

            services.AddTransient<IDriver, BloodPressureMedlabDriver>();
            services.AddTransient<IDriver, BloodPressureOmronDriver>();
            services.AddTransient<IDriver, OximeterMedlabDriver>();
            services.AddTransient<IDriver, OximeterWelchAllynDriver>();
            services.AddTransient<IDriver, ScaleKernDriver>();
        }
    }
}
