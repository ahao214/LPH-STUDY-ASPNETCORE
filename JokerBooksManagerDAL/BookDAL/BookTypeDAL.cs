using JokerBooksManagerComm.Comm;
using JokerBooksManagerDAL.Helper;
using JokerBooksManagerModels.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerDAL.BookDAL
{
    /// <summary>
    /// 数据访问层图书类别
    /// </summary>
    public class BookTypeDAL
    {
        #region 新增图书类别

        /// <summary>
        /// 新增图书类别
        /// </summary>
        /// <param name="readerType">图书类别</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool AddReaderType(ReaderType readerType)
        {
            StringBuilder sb = new StringBuilder();
            BookCommandType commandType = BookCommandType.Text;
            sb.Append("INSERT INTO ReaderType(ReaderTypeName)VALUES(@ReaderTypeName)");

            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeName",readerType .ReaderTypeName)
            };
            try
            {
                return DBHelper.ExecuteNoneQuery(sb.ToString(), commandType, paras) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 图书类别是否存在

        /// <summary>
        /// 图书类别是否存在
        /// </summary>
        /// <param name="readerType">图书类别</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public static bool IsExistReaderType(string typeName)
        {
            bool res = false;
            StringBuilder sb = new StringBuilder();
            BookCommandType commandType = BookCommandType.Text;
            sb.Append("SELECT Count(*) FROM ReaderType WHERE ReaderTypeName=@ReaderTypeName");
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeName",typeName)
            };
            try
            {
                object obj = DBHelper.ExecuteScalar(sb.ToString(), commandType, paras);
                res = obj.ChangeInt() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

        #endregion

        #region 获取所有图书类别

        /// <summary>
        /// 获取所有图书类别
        /// </summary>
        /// <returns></returns>
        public static List<BookType> GetBookTypes()
        {
            BookCommandType bookCommand = BookCommandType.Text;
            List<BookType> lst = new List<BookType>();
            StringBuilder sb = new StringBuilder();
            BookType bookType = new BookType();
            string sql = BuilderSqlHelper.SelectSql<BookType>(bookType, "BookType", "BookTypeId");

            SqlDataReader dr = DBHelper.ExecuteReader(sql, bookCommand);
            while (dr.Read())
            {
                BookType type = new BookType
                {
                    BookTypeId = dr["BookTypeId"].ChangeInt(),
                    BookTypeName = dr["BookTypeName"].ToString(),
                    Remark = dr["Remark"].ToString()
                };
                lst.Add(type);
            }
            dr.Close();

            return lst;
        }


        #endregion

        #region 根据ID获取图书类别

        /// <summary>
        /// 根据ID获取图书类别
        /// </summary>
        /// <param name="ID">图书类别ID</param>
        /// <returns>返回图书类别对象</returns>
        public static ReaderType GetReaderTypeById(int ID)
        {
            ReaderType type = new ReaderType();
            BookCommandType bookCommand = BookCommandType.Text; StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT ReaderTypeId,ReaderTypeName FROM ReaderType WHERE ReaderTypeId=@ReaderTypeId");
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeId",ID )
            };
            SqlDataReader dr = DBHelper.ExecuteReader(sb.ToString(), bookCommand, paras);
            if (dr.Read())
            {
                type = new ReaderType()
                {
                    ReaderTypeId = dr["ReaderTypeId"].ChangeInt(),
                    ReaderTypeName = dr["ReaderTypeName"].ToString()
                };
            }
            dr.Close();
            return type;
        }


        #endregion


        #region 更新图书类别

        /// <summary>
        /// 更新图书类别
        /// </summary>
        /// <param name="readerType">图书类别对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool UpdateReaderType(ReaderType readerType)
        {
            BookCommandType commandType = BookCommandType.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("Update ReaderType SET ReaderTypeName=@ReaderTypeName WHERE ReaderTypeId=@ReaderTypeId");
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeName",readerType.ReaderTypeName),
                new SqlParameter ("@ReaderTypeId",readerType.ReaderTypeId)
            };
            return DBHelper.ExecuteNoneQuery(sb.ToString(), commandType, paras) > 0;

        }

        #endregion



        #region 删除图书类别

        /// <summary>
        /// 删除图书类别
        /// </summary>
        /// <param name="readerType">图书类别ID</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool DeleteReaderType(int iReaderTypeId)
        {
            BookCommandType commandType = BookCommandType.Text;
            List<string> sqlList = new List<string>();

            StringBuilder sb = new StringBuilder();
            sb.Append("Delete From  ReaderInfo WHERE ReaderTypeId=@ReaderTypeId");
            sqlList.Add(sb.ToString());
            sb.Clear();
            sb.Append("Delete From  ReaderType WHERE ReaderTypeId=@ReaderTypeId");
            sqlList.Add(sb.ToString());


            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeId",iReaderTypeId)
            };

            return DBHelper.ExecuteSqlTrans(sqlList, commandType, paras);

        }

        #endregion



    }
}
