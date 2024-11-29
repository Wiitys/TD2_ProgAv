using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Menu
{
    public interface IMenuStrategy
    {
        string Name { get; }
        char Touche { get; }
        int Ordre { get; }

        Task RunAsync(CancellationToken cancellationToken = default);
    }
}
