using ExampleMicroServiceTodo.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMicroServiceTodo.DataAccess.UoW
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly DbContext dbContext;
        public UnitOfWork(DbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            dbContext.Dispose();
        }

        public ITodoRepository<T> GetRepository<T>() where T : class
        {
            return new TodoRepository<T>(dbContext);
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }
    }
}
