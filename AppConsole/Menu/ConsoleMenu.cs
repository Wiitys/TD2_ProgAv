using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD2.Interfaces;


namespace AppConsole.Menu
{
    public class ConsoleMenu
    {
        private readonly IEnumerable<IMenuStrategy> _strategies;

        public ConsoleMenu(IEnumerable<IMenuStrategy> strategies)
        {
            _strategies = strategies;
        }

        public async Task RunAsync(CancellationToken cancellationToken = default)
        {
            string? choix = null;
            bool stop = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Choisir une action :");
                foreach (var strategy in _strategies)
                {
                    Console.WriteLine(strategy.Name);
                }
                choix = Console.ReadLine();

                var current = _strategies.FirstOrDefault(x =>x.Touche.ToString() == choix);

                if(current == null)
                    continue;

                try
                {
                    await current.RunAsync(cancellationToken);
                }
                catch (Exception ex)
                {
                    stop = true;
                }
                
            }while (!stop);
        }
    }
}
