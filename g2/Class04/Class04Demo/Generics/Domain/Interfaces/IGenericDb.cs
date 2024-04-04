namespace Generics.Domain.Interfaces
{
    public interface IGenericDb<T>
    {
        void PrintAll();
        void Insert(T item);
        T GetById(int id);
        T GetByIndex(int index);
        void RemoveById(int id);
    }
}
