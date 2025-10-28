namespace trabalho.Repositories;

public interface ICanalRepository
{
    public void Save(Canal canal);

    public IEnumerable<Canal> GetAll();

    
}