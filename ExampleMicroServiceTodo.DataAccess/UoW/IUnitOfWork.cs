using ExampleMicroServiceTodo.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMicroServiceTodo.DataAccess.UoW
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        ITodoRepository<T> GetRepository<T>() where T : class;
    }
}
