using TD2.Models;

namespace TD2.Interfaces;

public interface ISemaineService : IService<Semaine>
{
    Semaine Creer(int annee, int numero);
}