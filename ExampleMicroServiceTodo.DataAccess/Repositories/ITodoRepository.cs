using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMicroServiceTodo.DataAccess.Repositories
{
    public interface ITodoRepository<T> where T : class
    {
        void Add(T model);
        void Update(T model);
        void Delete(T model);
        IQueryable<T> GetAll();
        T GetTodo(Func<T, bool> expression);
    }
}
