using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext context;
        public DbSet<T> DbSet;
        public Repository(DbContext _context)
        {
            context = _context;
            DbSet = context.Set<T>();
        }
        public void Add(T registro)
        {
            DbSet.Add(registro);
        }

        public T Get(int? id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = DbSet;
            return query.ToList();
        }

        public void Remove(T registro)
        {
            DbSet.Remove(registro);
        }

        public void Remove(int? id)
        {
            DbSet.Remove(DbSet.Find(id));
        }
    }
}
