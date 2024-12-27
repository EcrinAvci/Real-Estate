using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Villa.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TCreateAsync(T entity);
        Task TUpdateAsync(T entity);
        Task TDeleteAsync(ObjectId id);

        Task<List<T>> TGetListAsync();
        Task<T> TGetByIdAsync(ObjectId id);

        Task<int> TCountAsync();

        Task<List<T>> TGetFiltredListAsync(Expression<Func<T, bool>> predicate);
    }
}
