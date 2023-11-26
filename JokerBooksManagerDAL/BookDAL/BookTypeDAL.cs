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
        /// <param name="bookType">图书类别</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool AddBookType(BookType bookType)
        {
            BookCommandType commandType = BookCommandType.Text;
            string sql = BuilderSqlHelper.InsertSql<BookType>(bookType, "BookType", "BookTypeId");
            return DBHelper.ExecuteNoneQuery(sql, commandType) > 0;
        }

        #endregion

        #region 图书类别是否存在

        /// <summary>
        /// 图书类别是否存在
        /// </summary>
        /// <param name="readerType">图书类别</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public static bool IsExistBookType(string typeName)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("BookTypeName", typeName);
            BookCommandType commandType = BookCommandType.Text;
            BookType bookType = new BookType();
            string sql = BuilderSqlHelper.SelectSql<BookType>(bookType, "BookType", "BookTypeId", dic);

            return DBHelper.GetDataTable(sql, commandType).DefaultView.Count > 0;
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
        public static BookType GetBookTypeById(int ID)
        {
            BookType type = new BookType();
            BookCommandType bookCommand = BookCommandType.Text;
            Dictionary<string, object> dic = new Dictionary<string, object>
            {
                { "BookTypeId",ID }
            };
            string sql = BuilderSqlHelper.SelectSql<BookType>(type, "BookType", "BookTypeId", dic);
            SqlDataReader dr = DBHelper.ExecuteReader(sql, bookCommand);
            if (dr.Read())
            {
                type = new BookType
                {                    
                    BookTypeName = dr["BookTypeName"].ToString(),
                    Remark = dr["Remark"].ToString()
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
        /// <param name="bookType">图书类别对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool UpdateBookType(BookType bookType)
        {
            BookCommandType commandType = BookCommandType.Text;            
            string sql = BuilderSqlHelper.UpdateSql<BookType>(bookType, "BookType", "BookTypeId", bookType.BookTypeId);

            return DBHelper.ExecuteNoneQuery(sql, commandType) > 0;

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
