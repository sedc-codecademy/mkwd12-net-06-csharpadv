

using QinshiftAcademy.TryBeingFit.Domain.Models;

namespace QinshiftAcademy.TryBeingFit.Domain.Database
{
    public interface IDatabase<T> where T : BaseEntity
    {
        //offer signatures for CRUD operations

        //Create a record
        void Insert(T entity); //entity is the new item that is to be added in the collection

        
        //Reading info

        List<T> GetAll();
        T GetById(int id); //all entities have id, so we can search by id

        //Update a record
        void Update(T entity); //entity contains the new information used for update

        //Delete a record
        void DeleteById(int id);
    }
}
