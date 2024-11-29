namespace TD2.Models;

public class Semaine : IComparable<Semaine>
{
    public int Annee { get; set; }
    public int Numero { get; set; }
    public IEnumerable<Cours> Cours { get; set; } = new List<Cours>();
    
    public int CompareTo(Semaine? other)
    {
        if (other == null)
            return 1;

        if (Annee < other.Annee) return -1;
        
        if (Annee > other.Annee) return 1;
        
        // Si le résultat de la soustraction est négatif,
        // on est plus petit, etc
        return Numero - other.Numero;
    }
}