namespace TD2.Models;

public class Cours
{
    public int HeureDebut { get; set; }
    public int HeureFin { get; set; }
    public Matiere Matiere { get; set; }
    public IEnumerable<Classe> Classes { get; set; } = new List<Classe>();
}