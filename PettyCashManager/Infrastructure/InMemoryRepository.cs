using System;
using System.Collections.Generic;

namespace PettyCashManager.Infrastructure
{
    // In-memory implementation of IRepository<T>
    // Stores data temporarily using a Dictionary
    public class InMemoryRepository<T> : IRepository<T>
    {
        // Internal storage where:
        // Key = Guid (Id)
        // Value = object of type T
        private readonly Dictionary<Guid, T> _store = new();

        // Helper method to fetch Id property from any object T
        private Guid GetId(T item)
        {
            // Uses reflection to get the Id property
            var property = typeof(T).GetProperty("Id");

            // Convert the value to Guid
            return (Guid)property.GetValue(item);
        }

        // Adds a new item to the repository
        public void Add(T item)
        {
            var id = GetId(item);
            _store[id] = item;
        }

        // Returns all stored items
        public IEnumerable<T> GetAll()
        {
            return _store.Values;
        }

        // Returns a single item by Id
        public T GetById(Guid id)
        {
            return _store.ContainsKey(id) ? _store[id] : default;
        }

        // Updates an existing item
        public void Update(T item)
        {
            var id = GetId(item);
            _store[id] = item;
        }

        // Removes an item by Id
        public void Remove(Guid id)
        {
            _store.Remove(id);
        }
    }
}
