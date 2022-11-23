using ExampleMicroServiceUser.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMicroServiceUser.DataAccess.UoW
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        IUserRepository<T> GetRepository<T>() where T : class;
    }
}
