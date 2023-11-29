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
    /// 业务逻辑层：作者
    /// </summary>
    public class AuthorBLL
    {

        #region 新增作者

        /// <summary>
        /// 新增作者
        /// </summary>
        /// <param name="readerType">作者</param>
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

        #region 作者是否重复

        /// <summary>
        /// 作者是否存在
        /// </summary>
        /// <param name="readerType">作者</param>
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

        #region 获取所有作者

        /// <summary>
        /// 获取所有作者
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


        #region 根据ID获取作者

        /// <summary>
        /// 根据ID获取作者
        /// </summary>
        /// <param name="ID">作者ID</param>
        /// <returns>返回作者对象</returns>
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


        #region 更新作者

        /// <summary>
        /// 更新作者
        /// </summary>
        /// <param name="author">作者对象</param>
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

        #region 删除作者

        /// <summary>
        /// 删除作者
        /// </summary>
        /// <param name="readerType">作者ID</param>
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
