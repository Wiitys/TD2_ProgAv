using TD2.Interfaces;
using TD2.Models;

namespace TD2.Services;

public class CoursService : ABaseService<Cours>, ICoursService
{
    public Cours Creer(int debut, int fin, Matiere matiere, IEnumerable<Classe> classes)
    {
        var cours = new Cours
        {
            HeureDebut = debut,
            HeureFin = fin,
            Matiere = matiere,
            Classes = classes,
        };
        
        _list.Add(cours);
        
        return cours;
    }
}