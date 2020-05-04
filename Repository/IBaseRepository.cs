using System.Collections.Generic;

namespace Repository
{
    public interface IBaseRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
    }
}
