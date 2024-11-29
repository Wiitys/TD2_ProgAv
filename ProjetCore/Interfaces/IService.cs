namespace TD2.Interfaces;

public interface IService<TObject>
{
    TObject Creer(IDictionary<string, object> properties);
    TObject? Recuperer(Func<TObject, bool> predicate);
    IEnumerable<TObject> Lister(Func<TObject, bool>? predicate);
}