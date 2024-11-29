using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TD2.Interfaces;

namespace AppConsole.Menu.Strategies
{
    public class ListerSemainesMenuStrategy : ABaseMenuStrategy
    {
        public override string Name { get; } = "lister";
        public override char Touche { get; } = 'l';

        public override int Ordre { get; } = 1;


        private readonly ISemaineService _semaineService;

        public ListerSemainesMenuStrategy(ISemaineService semaineService)
        {
            _semaineService = semaineService;
        }

        protected override Task ActionAsync(CancellationToken cancellationToken)
        {
            foreach (var semaine in _semaineService.Lister(null))
            {
                Console.WriteLine("Semaine {0}", semaine.Numero);
            }
            Console.WriteLine("Entrer pour revenir au menu précédent");

            return Task.CompletedTask;

        }
    } 
}
