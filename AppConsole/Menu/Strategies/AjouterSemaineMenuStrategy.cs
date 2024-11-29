using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD2.Interfaces;

namespace AppConsole.Menu.Strategies
{
    public class AjouterSemaineMenuStrategy : ABaseMenuStrategy
    {
        public override string Name { get; } = "Ajouter";
        public override char Touche { get; } = 'a';

        public override int Ordre { get; } = 2;

        private readonly ISemaineService _semaineService;
        public AjouterSemaineMenuStrategy(ISemaineService semaineService)
        {
            _semaineService = semaineService;
        }

        protected override Task ActionAsync(CancellationToken cancellationToken)
        {
            int? annee = null;
            int? num = null;

            do
            {
                Console.WriteLine("Saisir année");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int output) && output > DateTime.UtcNow.Year)
                {
                    annee = output;
                } 
            } while (annee == null);

            do
            {
                Console.WriteLine("Saisir numéro");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int output) && output < 52)
                {
                    num = output;
                }
            } while (num == null);

            var paramaters = new Dictionary<string, Object>()
            {
                {"Annee", annee},
                {"Numero", num }
            };
            _semaineService.Creer(paramaters);
            return Task.CompletedTask;

        }
    }
}
