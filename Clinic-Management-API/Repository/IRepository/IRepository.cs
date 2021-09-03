using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Clinic_Management_API.Repository.IRepository
{
    public interface IRepository<T> where T : class 
    {
    // Add
    void Add(T entity);
    bool AddTypeBool(T entity);
    bool UpdateTypeBool(T entity);
    bool DeleteTypeBool(T entity);
    bool SaveChange();
    void AddRange(IEnumerable<T> entites);

    Task AddAsync(T entity);

    //Task<T> AddRangeAsync(T entites);

    // Remove
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
    Task RemoveRangeAsync(IEnumerable<T> entites);

    // Get

    IEnumerable<T> GetAll();
    IEnumerable<T> GetAll(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = null
    );

    Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
    T FirstOrDefault(
        Expression<Func<T, bool>> predicate,
        string includeProperties = null);

    T GetById(int? id);
    T GetById(int id);
    T GetById(string id);
    //Task<T> GetByIdAsync(int id);
    //Task<T> GetByIdAsync(string id);
    Task<IEnumerable<T>> GetAllAsync();

    // Find
    //T Find(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    // Update
    void Update(T entity);
    //Task<T> UpdateAsync(T entity);
    }
    // Existing
}