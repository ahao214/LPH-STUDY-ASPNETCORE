using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JokerBooksManagerModels.Model;
using System.Data;
using System.Data.SqlClient;
using JokerBooksManagerDAL.Helper;
using JokerBooksManagerComm.Comm;



namespace JokerBooksManagerDAL.BookDAL
{
    /// <summary>
    /// 数据库访问层管理员类
    /// </summary>
    public class ManagerDAL
    {
        #region 返回Manager对象

        /// <summary>
        /// 返回Manager对象
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <param name="loginPass">密码</param>
        /// <returns></returns>
        public static Manager GetManagerByNameAndPass(string loginName, string loginPass)
        {
            StringBuilder sb = new StringBuilder();
            BookCommandType commandType = BookCommandType.Text;
            sb.Append("SELECT Id,LoginName,LoginPass,IsSupper From Manager ");
            sb.Append(" WHERE LoginName=@LoginName AND LoginPass=@LoginPass");
            SqlParameter[] paras =
            {
                new SqlParameter ("@LoginName",loginName ),
                new SqlParameter ("@LoginPass",loginPass )
            };
            DataTable dt = DBHelper.GetDataTable(sb.ToString(), commandType, paras);
            Manager manager = default;
            foreach (DataRow dr in dt.Rows)
            {
                manager = new Manager
                {
                    Id = dr["Id"].ChangeInt(),
                    LoginName = dr["LoginName"].ToString(),
                    LoginPass = dr["LoginPass"].ToString(),
                    IsSupper = dr["IsSupper"].ChangeShort()
                };
            }
            return manager;
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
            StringBuilder sb = new StringBuilder();
            BookCommandType commandType = BookCommandType.Text;
            sb.Append("UPDATE Manager SET LoginPass=@LoginPass WHERE Id=@Id");
            SqlParameter[] parameters = {
                new SqlParameter ("@LoginPass",manager .LoginPass ),
                new SqlParameter ("@Id",manager .Id )
            };
            try
            {
                return DBHelper.ExecuteNoneQuery(sb.ToString(), commandType, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

    }
}
