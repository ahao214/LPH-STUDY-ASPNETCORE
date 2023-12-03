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
    /// 业务逻辑层：图书信息
    /// </summary>
    public class BookInfoBLL
    {

        #region 新增图书信息

        /// <summary>
        /// 新增图书信息
        /// </summary>
        /// <param name="readerType">图书信息</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool AddAuthor(Author author)
        {
            try
            {
                return AuthorDAL.AddAuthor(author);
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
        /// <param name="readerType">图书信息</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool IsExistAuthor(string authorName)
        {
            try
            {
                return AuthorDAL.IsExistAuthor(authorName);
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
        public List<Author> GetAuthors()
        {
            try
            {
                return AuthorDAL.GetAuthors();
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
        public Author GetAuthorById(int ID)
        {
            try
            {
                return AuthorDAL.GetAuthorById(ID);
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
        /// <param name="author">图书信息对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public bool UpdateAuthor(Author author)
        {
            try
            {
                return AuthorDAL.UpdateAuthor(author);
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
        public bool DeleteAuthor(int id)
        {
            try
            {
                return AuthorDAL.DeleteAuthor(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion
    }
}
