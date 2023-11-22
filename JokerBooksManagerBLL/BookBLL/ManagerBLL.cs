using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JokerBooksManagerDAL;
using JokerBooksManagerModels.Model;
using JokerBooksManagerDAL.BookDAL;


namespace JokerBooksManagerBLL.BookBLL
{
    /// <summary>
    /// 
    /// </summary>
    public class ManagerBLL
    {
        #region 返回Manager对象

        /// <summary>
        /// 返回Manager对象
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <param name="loginPass">密码</param>
        /// <returns></returns>
        public Manager GetManagerByNameAndPass(string loginName, string loginPass)
        {
            try
            {
                return ManagerDAL.GetManagerByNameAndPass(loginName, loginPass);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region 更新管理员密码

        /// <summary>
        /// 更新管理员密码
        /// </summary>
        /// <param name="manager">管理员对象</param>
        /// <returns>大于0：修改成功 小于0：修改失败</returns>
        public static int UpdatePassById(Manager manager)
        {
            try
            {
                return ManagerDAL.UpdatePassById(manager);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
