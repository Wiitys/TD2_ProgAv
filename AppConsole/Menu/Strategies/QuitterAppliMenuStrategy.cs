using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD2.Interfaces;

namespace AppConsole.Menu.Strategies
{
    public class QuitterAppliMenuStrategy : ABaseMenuStrategy
    {
        public override string Name { get; } = "Quitter";
        public override char Touche { get; } = 'q';

        public override int Ordre { get; } = 3;
        protected override Task ActionAsync(CancellationToken cancellationToken)
        {
            
            return Task.FromException(new OperationCanceledException());
        }

    }
}
