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
        /// <param name="bookInfo">图书信息</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool AddBookInfo(BookInfo bookInfo)
        {
            BookCommandType commandType = BookCommandType.Text;
            string sql = BuilderSqlHelper.InsertSql<BookInfo>(bookInfo, "BookInfo", "BookId");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into BookInfo(BookName,BookNumber,PublishId,PublishDate,BookTypeId,AuthorId,BookPrice ,InputName,TotalCount,BookSamry)");
            sb.AppendLine("values(@BookName,@BookNumber,@PublishId,@PublishDate,@BookTypeId,@AuthorId,@BookPrice ,@InputName,@TotalCount,@BookSamry)");
            SqlParameter[] parameters =
            {
                new  SqlParameter ("@BookName",bookInfo.BookName),
                new  SqlParameter ("@BookNumber",bookInfo.BookNumber),
                new  SqlParameter ("@PublishId",bookInfo.PublishId),
                new  SqlParameter ("@PublishDate",bookInfo.PublishDate),
                new  SqlParameter ("@BookTypeId",bookInfo.BookTypeId),
                new  SqlParameter ("@AuthorId",bookInfo.AuthorId),
                new  SqlParameter ("@BookPrice",bookInfo.BookPrice),
                new  SqlParameter ("@InputName",bookInfo.InputName),
                new  SqlParameter ("@TotalCount",bookInfo.TotalCount),
                new  SqlParameter ("@BookSamry",bookInfo.BookSamry),
                //new  SqlParameter ("@ConvrImage",bookInfo.ConvrImage)
            };

            return DBHelper.ExecuteNoneQuery(sb.ToString(), commandType, parameters) > 0;
        }

        #endregion

        #region 图书信息是否存在

        /// <summary>
        /// 图书信息是否存在
        /// </summary>
        /// <param name="bookInfoName">图书信息</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public static bool IsExistBookInfo(string bookName)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("BookName", bookName);
            BookCommandType commandType = BookCommandType.Text;
            BookInfo BookInfo = new BookInfo();
            string sql = BuilderSqlHelper.SelectSql<BookInfo>(BookInfo, "BookInfo", "BookId", dic);

            return DBHelper.GetDataTable(sql, commandType).DefaultView.Count > 0;
        }

        #endregion

        #region 获取所有图书信息

        /// <summary>
        /// 获取所有图书信息
        /// </summary>
        /// <returns></returns>
        public static List<BookInfo> GetBookInfos(int bookTypeId)
        {
            BookCommandType bookCommand = BookCommandType.Text;
            List<BookInfo> lst = new List<BookInfo>();
            StringBuilder sb = new StringBuilder();
            BookInfo bookInfo = new BookInfo();
            string sql = string.Empty;
            if (bookTypeId == 0)
            {
                sql = BuilderSqlHelper.SelectSql<BookInfo>(bookInfo, "BookInfo", "BookId");
            }
            else
            {
                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"BookTypeID",bookTypeId }
                };

                sql = BuilderSqlHelper.SelectSql<BookInfo>(bookInfo, "BookInfo", "", dic);
            }

            SqlDataReader dr = DBHelper.ExecuteReader(sql, bookCommand);
            while (dr.Read())
            {
                BookInfo auth = new BookInfo
                {
                    BookId = dr["BookId"].ChangeInt(),
                    BookName = dr["BookName"].ToString(),
                    BookNumber = dr["BookNumber"].ToString(),
                    PublishId = dr["PublishId"].ChangeInt(),
                    PublishDate = Convert.ToDateTime(dr["PublishDate"]),
                    BookTypeId = dr["BookTypeId"].ChangeInt(),
                    AuthorId = dr["AuthorId"].ChangeInt(),
                    BookPrice = Convert.ToDecimal(dr["BookPrice"]),
                    InputName = dr["InputName"].ToString(),
                    BorrowCount = dr["BorrowCount"].ChangeInt(),
                    TotalCount = dr["TotalCount"].ChangeInt(),
                    BookSamry = dr["BookSamry"].ToString(),
                    //ConvrImage = (byte[])dr["ConvrImage"]
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
        public static BookInfo GetBookInfoById(int ID)
        {
            BookInfo bookInfo = new BookInfo();
            BookCommandType bookCommand = BookCommandType.Text;
            Dictionary<string, object> dic = new Dictionary<string, object>
            {
                { "BookId",ID }
            };
            string sql = BuilderSqlHelper.SelectSql<BookInfo>(bookInfo, "BookInfo", "BookId", dic);
            SqlDataReader dr = DBHelper.ExecuteReader(sql, bookCommand);
            if (dr.Read())
            {
                bookInfo = new BookInfo
                {
                    BookName = dr["BookName"].ToString(),
                    BookNumber = dr["BookNumber"].ToString(),
                    PublishId = dr["PublishId"].ChangeInt(),
                    PublishDate = Convert.ToDateTime(dr["PublishDate"]),
                    BookTypeId = dr["BookTypeId"].ChangeInt(),
                    AuthorId = dr["AuthorId"].ChangeInt(),
                    BookPrice = Convert.ToDecimal(dr["BookPrice"]),
                    InputName = dr["InputName"].ToString(),
                    BorrowCount = dr["BorrowCount"].ChangeInt(),
                    TotalCount = dr["TotalCount"].ChangeInt(),
                    BookSamry = dr["BookSamry"].ToString(),
                };
            }
            dr.Close();
            return bookInfo;
        }


        #endregion


        #region 更新图书信息

        /// <summary>
        /// 更新图书信息
        /// </summary>
        /// <param name="BookInfo">图书信息对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool UpdateBookInfo(BookInfo BookInfo)
        {
            BookCommandType commandType = BookCommandType.Text;
            string sql = BuilderSqlHelper.UpdateBookInfoSql<BookInfo>(BookInfo, "BookInfo", "BookId");
            List<SqlParameter> paras = BuilderSqlHelper.GetParameters(BookInfo, "");
            return DBHelper.ExecuteNoneQuery(sql, commandType, paras.ToArray()) > 0;
        }

        #endregion



        #region 删除图书信息

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <param name="id">图书信息ID</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool DeleteBookInfo(int id)
        {
            BookCommandType commandType = BookCommandType.Text;
            List<string> sqlList = new List<string>();
            StringBuilder sb = new StringBuilder();
            BookInfo BookInfo = new BookInfo()
            {
                BookId = id,
            };
            string sql = BuilderSqlHelper.DeleteSql<BookInfo>(BookInfo, "BookInfo", "BookId");
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

        #region 添加图书信息(另外一种方法)
        /// <summary>
        /// 添加图书信息(另外一种方法)
        /// </summary>
        /// <param name="bookInfo"></param>
        /// <returns></returns>
        public static bool NewAddBookInfo(BookInfo info)
        {
            BookCommandType type = BookCommandType.Text;
            string sql = BuilderSqlHelper.InsertSql(info, "BookId");
            List<SqlParameter> paras = BuilderSqlHelper.GetParameters(info, "BookId");

            return DBHelper.ExecuteNoneQuery(sql, type, paras.ToArray()) > 0;
        }
        #endregion


        #region 根据查询条件筛选图书

        /// <summary>
        /// 根据查询条件筛选图书
        /// </summary>
        /// <param name="searchTypeId"></param>
        /// <param name="keys"></param>
        /// <returns></returns>
        public static List<BookInfo> GetSearchBook(int searchTypeId, string keys)
        {
            BookCommandType bookCommand = BookCommandType.Text;
            List<BookInfo> lst = new List<BookInfo>();

            string sql = string.Empty;
            switch (searchTypeId)
            {
                case 1:
                    sql = "SELECT BookId,BookName,BookNumber,PublishId,PublishDate,BookTypeId,AuthorId,BookPrice,InputName,BorrowCount,TotalCount,BookSamry,ConvrImage FROM BookInfo WHERE BookNumber LIKE @BookNumber";

                    break;
                case 2:
                    sql = "SELECT BookId,BookName,BookNumber,BI.PublishId,PublishDate,BookTypeId,AuthorId,BookPrice,InputName,BorrowCount,TotalCount,BookSamry,ConvrImage FROM BookInfo AS BI INNER JOIN PublishHouse AS PH ON BI.PublishId = PH.PublishId WHERE PH.PublishName LIKE @PublishName";
                    break;
                case 3:
                    sql = "SELECT BookId,BookName,BookNumber,BI.PublishId,PublishDate,BI.BookTypeId,AuthorId,BookPrice,InputName,BorrowCount,TotalCount,BookSamry,ConvrImage FROM BookInfo AS BI INNER JOIN BookType AS BT ON BI.BookTypeId = BT.BookTypeId WHERE BT.BookTypeName LIKE @BookTypeName";
                    break;
                case 4:
                    sql = "SELECT BookId,BookName,BookNumber,BI.PublishId,PublishDate,BookTypeId,BI.AuthorId,BookPrice,InputName,BorrowCount,TotalCount,BookSamry,ConvrImage FROM BookInfo AS BI INNER JOIN Author AS AU ON BI.AuthorId =AU.AuthorId  WHERE AU.AuthorName LIKE @AuthorName";
                    break;
                default:
                    sql = "SELECT BookId,BookName,BookNumber.PublishId,PublishDate,BookTypeId,AuthorId,BookPrice,InputName,BorrowCount,TotalCount,BookSamry,ConvrImage FROM BookInfo ORDER BY BookId";
                    break;
            }

            SqlParameter[] paras =
            {
                new SqlParameter ("@BookNumber","%"+keys+"%"),
                new SqlParameter ("@PublishName","%"+keys+"%"),
                new SqlParameter ("@BookTypeName","%"+keys+"%"),
                new SqlParameter ("@AuthorName","%"+keys+"%"),
            };

            SqlDataReader dr = DBHelper.ExecuteReader(sql, bookCommand, paras);
            while (dr.Read())
            {
                BookInfo auth = new BookInfo
                {
                    BookId = dr["BookId"].ChangeInt(),
                    BookName = dr["BookName"].ToString(),
                    BookNumber = dr["BookNumber"].ToString(),
                    PublishId = dr["PublishId"].ChangeInt(),
                    PublishDate = Convert.ToDateTime(dr["PublishDate"]),
                    BookTypeId = dr["BookTypeId"].ChangeInt(),
                    AuthorId = dr["AuthorId"].ChangeInt(),
                    BookPrice = Convert.ToDecimal(dr["BookPrice"]),
                    InputName = dr["InputName"].ToString(),
                    BorrowCount = dr["BorrowCount"].ChangeInt(),
                    TotalCount = dr["TotalCount"].ChangeInt(),
                    BookSamry = dr["BookSamry"].ToString(),
                    //ConvrImage = (byte[])dr["ConvrImage"]
                };
                lst.Add(auth);
            }
            dr.Close();

            return lst;
        }


        #endregion

    }
}
