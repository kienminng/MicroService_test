namespace VideoManager.Repository.IRepository;

public interface IRepository<T,Guid>
{
    void Save(T entity);
    void Delete(T entity);  
    T FindById(Guid id);
    IEnumerable<T> GetAll();
}