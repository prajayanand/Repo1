using System.Collections.Generic;

public interface IRepository<T> where T : class
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}
public abstract class Entity
{
    public int Id { get; set; }
}
