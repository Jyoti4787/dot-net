namespace PettyCashManager.Infrastructure
{
    // IRepository defines generic CRUD operations
    // It works for ANY type (Transaction, AuditLogEntry, etc.)
    public interface IRepository<T>
    {
        // Adds a new item to the repository
        void Add(T item);

        // Returns all items from the repository
        IEnumerable<T> GetAll();

        // Returns a single item by its unique ID
        T GetById(Guid id);

        // Updates an existing item
        void Update(T item);

        // Removes an item using its ID
        void Remove(Guid id);
    }
}
