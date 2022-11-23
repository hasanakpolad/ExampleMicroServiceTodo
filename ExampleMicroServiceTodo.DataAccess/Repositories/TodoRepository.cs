using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMicroServiceTodo.DataAccess.Repositories
{
    public class TodoRepository<T> : ITodoRepository<T> where T : class
    {
        private DbContext dbContext;
        private DbSet<T> dbSet;
        public TodoRepository(DbContext _dbContext)
        {
            dbContext = _dbContext;
            dbSet = dbContext.Set<T>();
        }

        public void Add(T model)
        {
            dbSet.Add(model);
        }

        public void Delete(T model)
        {
            dbSet.Remove(model);
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public T GetTodo(Func<T, bool> expression)
        {
            var data = dbSet.Where(expression);
            return data.FirstOrDefault();
        }

        public void Update(T model)
        {
            dbSet.Attach(model);
            dbContext.Entry(model).State = EntityState.Modified;
        }
    }
}
