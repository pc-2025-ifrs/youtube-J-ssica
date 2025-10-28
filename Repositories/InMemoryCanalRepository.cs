using trabalho.Model;

namespace trabalho.Repositories;

//concreto
public class InMemoryCanalRepository : ICanalRepository
{

    private readonly Dictionary<Guid, Canal> _memory = [];


    public void Save(Canal canal)
    {
        var Id = Guid.NewGuid();
        // _memory.Add(canal.Id, canal);
        canal.Id = Id;
        _memory[Id] = canal;
    }

    public IEnumerable<Canal> GetAll() => _memory.Values;
}

