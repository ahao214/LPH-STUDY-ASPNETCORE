using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.VisualBasic;
using Simple.EntityFramworkCore.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simple.EntityFramworkCore.Core
{
    public class Repository<IDbContext, TEntity> : IRepository<TEntity> where TEntity : Entity
        where IDbContext : MasterDbContext<IDbContext>
    {
        public readonly IDbContext _dbContext;
        public readonly DbSet<TEntity> _dbSet;
        public Repository(IDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        /// <inheritdoc/>
        public async Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FirstAsync(predicate, cancellationToken: cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate, cancellationToken: cancellationToken);
        }
        /// <inheritdoc/>
        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbSet.Where(predicate).ToListAsync(cancellationToken);
        }
        /// <inheritdoc/>
        public async Task<IQueryable<TEntity>> GetQueryAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.FromResult(_dbSet.Where(predicate));
        }
        /// <inheritdoc/>
        public async Task<IQueryable<TResult>> GetQueryAsync<TResult>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TResult>> selector)
        {
            return await Task.FromResult(_dbSet.Where(predicate).Select(selector));
        }
        /// <inheritdoc/>
        public async Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            return (await _dbSet.AddAsync(entity, cancellationToken)).Entity;
        }
        /// <inheritdoc/>
        public async Task InsertManyAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddRangeAsync(entities, cancellationToken);
        }
        /// <inheritdoc/>
        public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _dbSet.CountAsync(predicate, cancellationToken) > 0;
        }

        /// <inheritdoc/>
        public async Task DeleteManyAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default)
        {
            var entity = await _dbSet.Where(x => ids.Contains(x.Id)).ToListAsync(cancellationToken: cancellationToken);
            if (entity.Count > 0)
            {
                _dbSet.RemoveRange(entity);
            }
        }
        /// <inheritdoc/>
        public Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            _dbSet.Remove(entity);
            return Task.CompletedTask;
        }
        /// <inheritdoc/>
        public Task DeleteManyAsync(IEnumerable<TEntity> entity, CancellationToken cancellationToken)
        {
            _dbSet.RemoveRange(entity);
            return Task.CompletedTask;
        }


        /// <inheritdoc/>
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            return await Task.FromResult(entity);
        }
        /// <inheritdoc/>
        public Task UpdateManyAsync(IEnumerable<TEntity> entities)
        {
            _dbSet.UpdateRange(entities);
            return Task.CompletedTask;
        }
        /// <inheritdoc/>
        Task<TEntity> IRepository<TEntity>.InsertManyAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
