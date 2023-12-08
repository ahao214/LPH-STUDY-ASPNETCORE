using JokerBooksManagerDAL.BookDAL;
using JokerBooksManagerDAL.Helper;
using JokerBooksManagerModels.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerBLL.BookBLL
{
    /// <summary>
    /// 业务逻辑层：图书信息
    /// </summary>
    public class BookInfoBLL
    {

        #region 新增图书信息

        /// <summary>
        /// 新增图书信息
        /// </summary>
        /// <param name="bookInfo">图书信息</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool AddBookInfo(BookInfo bookInfo)
        {
            try
            {
                return BookInfoDAL.AddBookInfo(bookInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 图书信息是否重复

        /// <summary>
        /// 图书信息是否存在
        /// </summary>
        /// <param name="bookName">图书信息</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool IsExistBookInfo(string bookName)
        {
            try
            {
                return BookInfoDAL.IsExistBookInfo(bookName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 获取所有图书信息

        /// <summary>
        /// 获取所有图书信息
        /// </summary>
        /// <returns>返回图书对象集合</returns>
        public List<BookInfo> GetBookInfos(int bookTypeId)
        {
            try
            {
                return BookInfoDAL.GetBookInfos(bookTypeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion


        #region 根据ID获取图书信息

        /// <summary>
        /// 根据ID获取图书信息
        /// </summary>
        /// <param name="ID">图书信息ID</param>
        /// <returns>返回图书信息对象</returns>
        public BookInfo GetBookInfoById(int ID)
        {
            try
            {
                return BookInfoDAL.GetBookInfoById(ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion


        #region 更新图书信息

        /// <summary>
        /// 更新图书信息
        /// </summary>
        /// <param name="BookInfo">图书信息对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public bool UpdateBookInfo(BookInfo bookInfo)
        {
            try
            {
                return BookInfoDAL.UpdateBookInfo(bookInfo);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region 删除图书信息

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <param name="readerType">图书信息ID</param>
        /// <returns>大于0：True 小于0：False</returns>
        public bool DeleteBookInfo(int id)
        {
            try
            {
                return BookInfoDAL.DeleteBookInfo(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion


        #region 获取数据库中最后一条图书编码
        /// <summary>
        /// 获取数据库中最后一条图书编码
        /// </summary>
        /// <returns></returns>
        public string GetBookNumber()
        {
            try
            {
                return BookInfoDAL.GetBookNumber();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        #endregion

        #region 根据查询条件筛选图书

        /// <summary>
        /// 根据查询条件筛选图书
        /// </summary>
        /// <param name="searchTypeId"></param>
        /// <param name="keys"></param>
        /// <returns></returns>
        public  List<BookInfo> GetSearchBook(int searchTypeId, string keys)
        {
            try
            {
                return BookInfoDAL.GetSearchBook(searchTypeId, keys);
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        #endregion
    }
}
