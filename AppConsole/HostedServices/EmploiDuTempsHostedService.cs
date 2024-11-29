using AppConsole.Menu;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.HostedServices
{
    public class EmploiDuTempsHostedService : BackgroundService
    {
        private readonly IHostApplicationLifetime _applicationLifetime;
        private readonly ConsoleMenu _menu;


        public EmploiDuTempsHostedService(IHostApplicationLifetime applicationLifetime, ConsoleMenu menu)
        {
            _applicationLifetime = applicationLifetime;
            _menu = menu;


        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            Console.WriteLine("EmploiDUTemps Hosted Service is running");

            await _menu.RunAsync(stoppingToken);
            _applicationLifetime.StopApplication();
        }
    }
}
