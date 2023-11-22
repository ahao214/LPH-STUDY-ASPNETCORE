using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerDAL.Helper;
using JokerBooksManagerModels.Model;


namespace JokerBooksManagerDAL.BookDAL
{
    /// <summary>
    /// 数据库访问层读者类别
    /// </summary>
    public class ReaderTypeDAL
    {
        #region 新增读者类别

        /// <summary>
        /// 新增读者类别
        /// </summary>
        /// <param name="readerType">读者类别</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public static int AddReaderType(ReaderType readerType)
        {
            StringBuilder sb = new StringBuilder();
            BookCommandType commandType = BookCommandType.Text;
            sb.Append("INSERT INTO ReaderType(ReadTypeName)VALUES(@ReadTypeName)");
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReadTypeName",readerType .ReadTypeName)
            };
            try
            {
                return DBHelper.ExecuteNoneQuery(sb.ToString(), commandType, paras);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
