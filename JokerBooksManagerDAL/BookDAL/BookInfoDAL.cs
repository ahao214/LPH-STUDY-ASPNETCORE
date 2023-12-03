using JokerBooksManagerComm.Comm;
using JokerBooksManagerDAL.Helper;
using JokerBooksManagerModels.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerDAL.BookDAL
{
    /// <summary>
    /// 数据访问层：图书信息
    /// </summary>
    public class BookInfoDAL
    {
        #region 新增图书信息

        /// <summary>
        /// 新增图书信息
        /// </summary>
        /// <param name="author">图书信息</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool AddAuthor(Author author)
        {
            BookCommandType commandType = BookCommandType.Text;
            string sql = BuilderSqlHelper.InsertSql<Author>(author, "Author", "AuthorId");
            return DBHelper.ExecuteNoneQuery(sql, commandType) > 0;
        }

        #endregion

        #region 图书信息是否存在

        /// <summary>
        /// 图书信息是否存在
        /// </summary>
        /// <param name="authorName">图书信息</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public static bool IsExistAuthor(string authorName)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("AuthorName", authorName);
            BookCommandType commandType = BookCommandType.Text;
            Author author = new Author();
            string sql = BuilderSqlHelper.SelectSql<Author>(author, "Author", "AuthorId", dic);

            return DBHelper.GetDataTable(sql, commandType).DefaultView.Count > 0;
        }

        #endregion

        #region 获取所有图书信息

        /// <summary>
        /// 获取所有图书信息
        /// </summary>
        /// <returns></returns>
        public static List<Author> GetAuthors()
        {
            BookCommandType bookCommand = BookCommandType.Text;
            List<Author> lst = new List<Author>();
            StringBuilder sb = new StringBuilder();
            Author author = new Author();
            string sql = BuilderSqlHelper.SelectSql<Author>(author, "Author", "AuthorId");

            SqlDataReader dr = DBHelper.ExecuteReader(sql, bookCommand);
            while (dr.Read())
            {
                Author auth = new Author
                {
                    AuthorId = dr["AuthorId"].ChangeInt(),
                    AuthorName = dr["AuthorName"].ToString(),
                    Remark = dr["Remark"].ToString()
                };
                lst.Add(auth);
            }
            dr.Close();

            return lst;
        }


        #endregion

        #region 根据ID获取图书信息

        /// <summary>
        /// 根据ID获取图书信息
        /// </summary>
        /// <param name="ID">图书信息ID</param>
        /// <returns>返回图书信息对象</returns>
        public static Author GetAuthorById(int ID)
        {
            Author author = new Author();
            BookCommandType bookCommand = BookCommandType.Text;
            Dictionary<string, object> dic = new Dictionary<string, object>
            {
                { "AuthorId",ID }
            };
            string sql = BuilderSqlHelper.SelectSql<Author>(author, "Author", "AuthorId", dic);
            SqlDataReader dr = DBHelper.ExecuteReader(sql, bookCommand);
            if (dr.Read())
            {
                author = new Author
                {
                    AuthorName = dr["AuthorName"].ToString(),
                    Remark = dr["Remark"].ToString()
                };
            }
            dr.Close();
            return author;
        }


        #endregion


        #region 更新图书信息

        /// <summary>
        /// 更新图书信息
        /// </summary>
        /// <param name="author">图书信息对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool UpdateAuthor(Author author)
        {
            BookCommandType commandType = BookCommandType.Text;
            string sql = BuilderSqlHelper.UpdateSql<Author>(author, "Author", "AuthorId", author.AuthorId);

            return DBHelper.ExecuteNoneQuery(sql, commandType) > 0;
        }

        #endregion



        #region 删除图书信息

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <param name="id">图书信息ID</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool DeleteAuthor(int id)
        {
            BookCommandType commandType = BookCommandType.Text;
            List<string> sqlList = new List<string>();
            StringBuilder sb = new StringBuilder();
            Author author = new Author();
            author.AuthorId = id;
            string sql = BuilderSqlHelper.DeleteSql<Author>(author, "Author", "AuthorId");
            sb.Append(sql);
            sqlList.Add(sb.ToString());
            return DBHelper.ExecuteSqlTrans(sqlList, commandType);

        }

        #endregion

        #region 获取数据库中最后一条图书编码
        /// <summary>
        /// 获取数据库中最后一条图书编码
        /// </summary>
        /// <returns></returns>
        public static string GetBookNumber()
        {
            BookCommandType type = BookCommandType.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TOP 1 BookNumber FROM BookInfo ORDER BY BookId DESC");
            SqlDataReader reader = DBHelper.ExecuteReader(sb.ToString(), type);
            string sBookNumber = string.Empty;
            if (reader.Read())
            {
                sBookNumber = reader["BookNumber"].ToString();
            }
            else
            {
                sBookNumber = "BN000000000";
            }
            reader.Close();
            return sBookNumber;
        }

        #endregion
    }
}
