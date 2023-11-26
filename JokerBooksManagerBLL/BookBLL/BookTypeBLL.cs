using JokerBooksManagerDAL.BookDAL;
using JokerBooksManagerModels.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerBLL.BookBLL
{
    /// <summary>
    /// 业务逻辑层图书类别
    /// </summary>
    public class BookTypeBLL
    {
        #region 新增图书类别

        /// <summary>
        /// 新增图书类别
        /// </summary>
        /// <param name="readerType">图书类别</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool AddBookType(BookType bookType)
        {
            try
            {
                return BookTypeDAL.AddBookType(bookType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 图书类别是否重复

        /// <summary>
        /// 图书类别是否存在
        /// </summary>
        /// <param name="readerType">图书类别</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool IsExistBookType(string typeName)
        {
            try
            {
                return BookTypeDAL.IsExistBookType(typeName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 获取所有图书类别

        /// <summary>
        /// 获取所有图书类别
        /// </summary>
        /// <returns>返回图书对象集合</returns>
        public List<BookType> GetBookTypes()
        {
            try
            {
                return BookTypeDAL.GetBookTypes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion


        #region 根据ID获取图书类别

        /// <summary>
        /// 根据ID获取图书类别
        /// </summary>
        /// <param name="ID">图书类别ID</param>
        /// <returns>返回图书类别对象</returns>
        public BookType GetBookTypeById(int ID)
        {
            try
            {
                return BookTypeDAL.GetBookTypeById(ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion


        #region 更新图书类别

        /// <summary>
        /// 更新图书类别
        /// </summary>
        /// <param name="readerType">图书类别对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public bool UpdateBookType(BookType bookType)
        {
            try
            {
                return BookTypeDAL.UpdateBookType(bookType);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region 删除图书类别

        /// <summary>
        /// 删除图书类别
        /// </summary>
        /// <param name="readerType">图书类别ID</param>
        /// <returns>大于0：True 小于0：False</returns>
        public bool DeleteReaderType(int iReaderTypeId)
        {
            try
            {
                return ReaderTypeDAL.DeleteReaderType(iReaderTypeId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion



    }
}
