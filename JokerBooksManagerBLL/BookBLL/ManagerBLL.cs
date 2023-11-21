using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JokerBooksManagerDAL;
using JokerBooksManagerModels;
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
    }
}
