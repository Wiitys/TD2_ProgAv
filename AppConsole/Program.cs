using Autofac;
using Autofac.Extensions.DependencyInjection;
using InMemory;
using Microsoft.Extensions.Hosting;
using System.Net.Mail;
using TD2.Services;
using TD2.AppConsole;
using AppConsole.Menu;
using AppConsole.HostedServices;
using Microsoft.Extensions.DependencyInjection;

namespace TD2.AppConsole;

class Program
{

    static async Task Main(string[] args)
    {
        await Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureServices(services => services.AddHostedService<EmploiDuTempsHostedService>())
            .ConfigureContainer<ContainerBuilder>(ConfigureAutoFac)
            .Build()
            .RunAsync();

        static void  ConfigureAutoFac(ContainerBuilder builder)
        {
            /*var inMemoryAssemby = typeof(InMemoryModule).Assembly;

            builder.RegisterAssemblyTypes(inMemoryAssemby);*/

            builder.RegisterModule<InMemoryModule>();
            builder.RegisterModule<MenuModule>();
        }
    }
}