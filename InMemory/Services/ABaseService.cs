using System.Reflection;
using TD2.Interfaces;

namespace TD2.Services;

public abstract class ABaseService<TObject> : IService<TObject>
{
    protected readonly IList<TObject> _list = new List<TObject>();
    
    public TObject Creer(IDictionary<string, object> properties)
    {
        // On instancie l'objet
        var instance = Activator.CreateInstance<TObject>();
        
        // On récupère les membres public
        var type = instance.GetType();  

        // On parcours les propriétés
        foreach (var property in properties)
        {
            var name = property.Key;
            var value = property.Value;
            
            // On récupère le membre si il est public
            var field = type.GetField(name, BindingFlags.Public | BindingFlags.Instance);

            // Si il n'existe pas, on continue
            if (field is null) continue;
            
            // Si les types ne correspondent pas, on laisse la valeur par défaut
            if (value is null || (!value.GetType().IsSubclassOf(field.FieldType) && value.GetType() != field.FieldType)) continue;
            
            // On set la valeur
            field.SetValue(instance, value);
        }
        
        _list.Add(instance);
        
        return instance;
    }

    public TObject? Recuperer(Func<TObject, bool> predicate)
    {
        return _list.FirstOrDefault(predicate);
    }

    public IEnumerable<TObject> Lister(Func<TObject, bool>? predicate)
    {
        if (predicate is null)
            return _list;
        
        return _list.Where(predicate);
    }
}
