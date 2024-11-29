using TD2.Interfaces;
using TD2.Models;

namespace TD2.Services;

public class SemaineService : ABaseService<Semaine>, ISemaineService
{
    public Semaine Creer(int annee, int numero)
    {
        var semaine = new Semaine
        {
            Annee = annee,
            Numero = numero,
        };
        
        _list.Add(semaine);
        
        return semaine;
    }
}