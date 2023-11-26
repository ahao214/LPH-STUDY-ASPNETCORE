using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simple.EntityFramworkCore.Core.Base
{
    public interface IRepository<IEntity> where IEntity : Entity
    {
        /// <summary>
        /// 返回满足条件的第一个元素可空
        /// </summary>
        /// <param name="exceptionHandler"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEntity?> FirstOrDefaultAsync(Expression<Func<IEntity, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>
        /// 返回满足条件的第一个元素不存在抛出异常
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEntity> FirstAsync(Expression<Func<IEntity, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<IEntity>> GetListAsync(Expression<Func<IEntity, bool>> predicate, CancellationToken cancellationToken = default);



        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> IsExistAsync(Expression<Func<IEntity, bool>> predicate, CancellationToken cancellationToken = default);


        /// <summary>
        /// 获取到IQueryable
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IQueryable<IEntity>> GetQueryAsync(Expression<Func<IEntity, bool>> predicate);


        Task<IQueryable<TResult>> GetQueryAsync<TResult>(Expression<Func<IEntity, bool>> predicate, Expression<Func<IEntity, TResult>> selector);


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEntity> InsertAsync(IEntity entity, CancellationToken cancellationToken = default);


        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEntity> InsertManyAsync(IEnumerable<IEntity> entities, CancellationToken cancellationToken = default);


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);


        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task DeleteManyAsync(IEnumerable<IEntity> entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<IEntity> UpdateAsync(IEntity entity);
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task UpdateManyAsync(IEnumerable<IEntity> entities);
    }
}
