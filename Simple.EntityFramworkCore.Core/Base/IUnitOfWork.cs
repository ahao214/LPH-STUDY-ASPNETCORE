using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simple.EntityFramworkCore.Core.Base
{
    /// <summary>
    /// 工作单元
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 开启事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 保存更改
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 提交事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task CommitTransactionAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 回滚事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task RollbackTransactionAsync(CancellationToken cancellationToken = default);

    }
}
