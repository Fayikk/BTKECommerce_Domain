using BTKECommerce_Domain.Entities.Base;

namespace BTKECommerce_Domain.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        //Create
        void Add(T entity);
        //Delete
        void Delete(T entity);
        //Update
        //GetAll
        Task<IEnumerable<T>> GetAll();
        //Get
        Task<T> GetById(Guid Id);
        T Update(T entity);
    }
}
