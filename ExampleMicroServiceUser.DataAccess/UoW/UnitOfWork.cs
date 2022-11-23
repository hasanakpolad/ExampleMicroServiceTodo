using ExampleMicroServiceUser.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ExampleMicroServiceUser.DataAccess.UoW
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private DbContext dbContext;
        public UnitOfWork(DbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);

        }

        public IUserRepository<T> GetRepository<T>() where T : class
        {
            return new UserRepository<T>(dbContext);
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }
    }
}
