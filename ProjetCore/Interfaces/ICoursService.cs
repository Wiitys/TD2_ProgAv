using TD2.Models;

namespace TD2.Interfaces;

public interface ICoursService : IService<Cours>
{
    Cours Creer(int debut, int fin, Matiere matiere, IEnumerable<Classe> classes);
}