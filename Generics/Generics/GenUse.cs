using System;
using System.Collections.Generic;
using System.Linq;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private readonly List<T> _context = new List<T>();

    public void Add(T item)
    {
        _context.Add(item);
    }

    public void Remove(T item)
    {
        _context.Remove(item);
    }

    public void Save()
    {
        // In-memory save doesn't require implementation, but it's here for consistency.
    }

    public IEnumerable<T> GetAll()
    {
        return _context;
    }

    public T GetById(int id)
    {
        return _context.FirstOrDefault(e => e.Id == id);
    }
}