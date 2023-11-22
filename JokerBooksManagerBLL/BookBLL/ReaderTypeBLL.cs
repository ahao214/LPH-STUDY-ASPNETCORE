using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JokerBooksManagerModels.Model;
using JokerBooksManagerDAL.BookDAL;
using JokerBooksManagerDAL.Helper;
using System.Data.SqlClient;


namespace JokerBooksManagerBLL.BookBLL
{
    /// <summary>
    /// 业务逻辑层读者类别
    /// </summary>
    public class ReaderTypeBLL
    {
        #region 新增读者类别

        /// <summary>
        /// 新增读者类别
        /// </summary>
        /// <param name="readerType">读者类别</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public int AddReaderType(ReaderType readerType)
        {
            try
            {
                return ReaderTypeDAL.AddReaderType(readerType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 读者类别是否重复

        /// <summary>
        /// 读者类别是否存在
        /// </summary>
        /// <param name="readerType">读者类别</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool IsExistReaderType(string typeName)
        {
            try
            {
                return ReaderTypeDAL.IsExistReaderType(typeName);
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        #endregion


    }
}
