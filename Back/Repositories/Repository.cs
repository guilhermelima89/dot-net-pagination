using Api.Data;
using Api.Interfaces;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity, new()
    {
        protected readonly ApplicationDbContext Context;
        protected readonly DbSet<T> DbSet;

        protected Repository(ApplicationDbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await DbSet
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await DbSet
                .AsNoTrackingWithIdentityResolution()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbSet
                .Where(predicate)
                .AsNoTrackingWithIdentityResolution()
                .ToListAsync();
        }

        public async Task Add(T entity)
        {
            DbSet.Add(entity);
            await Commit();
        }

        public async Task Update(T entity)
        {
            DbSet.Update(entity);
            await Commit();
        }

        public async Task Remove(int id)
        {
            DbSet.Remove(new T { Id = id });
            await Commit();
        }

        private async Task Commit()
        {
            await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
