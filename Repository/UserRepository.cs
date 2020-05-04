using System.Collections.Generic;
using Repository.DomainModel;

namespace Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private AppDbContext _context;
        public UserRepository(AppDbContext context) : base(context)
        {
        }
        public IEnumerable<User> GetUsers()
        {
            return GetAll();
        }
    }
}
