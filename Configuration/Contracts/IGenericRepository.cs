using LeaveManagement.Data;

namespace LeaveManagement.Configuration.Contracts
{
    //Handling basic crud opr
    //This is for elemenating all duplicate codes -> inhritance imp.
    // Migrate leaveTypeController --> Repo.GenericClass Which implements this interface  
    // this interface takes any type of classes so make it genericType 
    public interface IGenericRepository<T> where T : class
    {
        //with return
        Task<T> GetAsync(int? id); //get by id specific
        Task<List<T>> GetAllAsync(); // get all in list
        Task<T> AddAsync(T entity);
        Task<bool> Exists(int id);

        //No return 
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
    }
}
