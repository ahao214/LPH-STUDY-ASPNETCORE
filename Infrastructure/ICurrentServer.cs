using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface ICurrentServer
    {
        /// <summary>
        /// 是否授权
        /// </summary>
        /// <returns></returns>
        bool? IsAuthenticated();
        /// <summary>
        /// 用户ID
        /// </summary>
        /// <returns></returns>
        Guid? UserId();
        /// <summary>
        /// 获取用户ID
        /// </summary>
        /// <returns></returns>
        Guid GetUserId();
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T? UserInfo<T>();

    }

    public class CurrentServer : ICurrentServer
    {
        public Guid GetUserId()
        {
            var userId = UserId ();
            if (userId == null)
                throw new BusinessException("账号未登录");

            return (Guid)userId;
        }

        public bool? IsAuthenticated()
        {
            throw new NotImplementedException();
        }

        public Guid? UserId()
        {
            throw new NotImplementedException();
        }

        public T? UserInfo<T>()
        {
            throw new NotImplementedException();
        }
    }
}
