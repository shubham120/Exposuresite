using System.Collections.Generic;
using Repository.DomainModel;

namespace Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public IEnumerable<User> GetUsers();
    }
}
