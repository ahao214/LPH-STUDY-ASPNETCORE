using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.VisualBasic;
using Simple.EntityFramworkCore.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.EntityFramworkCore.Core
{
    public class UnitOfWork<TDbContext> : IUnitOfWork where TDbContext : MasterDbContext<TDbContext>, IDisposable
    {
        public bool IsDisposed { get; private set; }
        public bool IsCompleted { get; private set; }

        private readonly TDbContext _dbContext;

        public UnitOfWork(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            IsCompleted = false;
            await _dbContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (IsCompleted)
                return;

            IsCompleted = true;

            ApplyChangeConventions();
            try
            {
                // 提交事务
                await _dbContext.SaveChangesAsync(cancellationToken ).ConfigureAwait(false);
                await _dbContext.Database.CommitTransactionAsync (cancellationToken ).ConfigureAwait (false);
            }
            catch (Exception)
            {
                // 发生异常回滚事务
                await RollbackTransactionAsync(cancellationToken).ConfigureAwait(false);    
                throw;
            }
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.Database.RollbackTransactionAsync(cancellationToken);
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            ApplyChangeConventions();
            return await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        private void ApplyChangeConventions()
        {
            _dbContext.ChangeTracker.DetectChanges();
            foreach (var entry in _dbContext.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        UnitOfWork<TDbContext>.SetCreation(entry);
                        break;
                }
            }
        }

        private static void SetCreation(EntityEntry entry)
        {
            if (entry.Entity is Entity creator)
            {
                creator.CreatedTime = DateTime.Now;
            }


        }
    }
}
