using Core.DBInteraction.Mappings;

namespace Core.DBInteraction
{
    public interface IRepositoryShell
    {
        T Get<T>();
        T GetbyId<T>(int id) where T : IIdentity;
        List<T> GetAll<T>();
        void Update<T>(T item);
        void Add<T>(T item);
        void AddWithId(IIdentity item);
        void AddOrUpdate<T>(T item);
        void Delete<T>(T item);
        void DeleteAll<T>();
        int Count<T>();
    }
}
