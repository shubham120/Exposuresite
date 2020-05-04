using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private AppDbContext _context;
        private DbSet<T> entity;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
            entity = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entity.ToList();
        }
    }
}
