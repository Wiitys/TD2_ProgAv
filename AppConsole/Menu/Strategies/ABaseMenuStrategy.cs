using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Menu.Strategies
{
    public abstract class ABaseMenuStrategy : IMenuStrategy
    {
        public abstract string Name {  get; }
        public abstract char Touche { get; }
        public abstract int Ordre { get; }
        public async Task RunAsync(CancellationToken cancellationToken = default)
        {
            Console.Clear();

            cancellationToken.ThrowIfCancellationRequested();

            await ActionAsync(cancellationToken);
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }

        protected abstract Task ActionAsync(CancellationToken cancellationToken);
    }
}
