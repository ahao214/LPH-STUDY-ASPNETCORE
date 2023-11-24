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
    /// 业务逻辑层读者信息
    /// </summary>
    public class ReaderInfoBLL
    {
        #region 新增读者

        /// <summary>
        /// 新增读者
        /// </summary>
        /// <param name="readerType">读者</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool AddReaderType(ReaderType readerType)
        {
            try
            {
                return ReaderInfoDAL.AddReaderType(readerType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 读者是否重复

        /// <summary>
        /// 读者是否存在
        /// </summary>
        /// <param name="readerType">读者</param>
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

        #region 获取所有读者

        /// <summary>
        /// 获取所有读者
        /// </summary>
        /// <returns>返回读者对象集合</returns>
        public List<ReaderInfoExpend> GetReaderInfos()
        {
            try
            {
                return ReaderInfoDAL.GetReaderInfos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion


        #region 根据ID获取读者

        /// <summary>
        /// 根据ID获取读者
        /// </summary>
        /// <param name="ID">读者ID</param>
        /// <returns>返回读者对象</returns>
        public ReaderType GetReaderTypeById(int ID)
        {
            try
            {
                return ReaderInfoDAL.GetReaderTypeById(ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion


        #region 更新读者

        /// <summary>
        /// 更新读者
        /// </summary>
        /// <param name="readerType">读者对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public bool UpdateReaderType(ReaderType readerType)
        {
            try
            {
                return ReaderInfoDAL.UpdateReaderType(readerType);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region 删除读者

        /// <summary>
        /// 删除读者
        /// </summary>
        /// <param name="readerType">读者ID</param>
        /// <returns>大于0：True 小于0：False</returns>
        public bool DeleteReaderType(int iReaderTypeId)
        {
            try
            {
                return ReaderInfoDAL.DeleteReaderType(iReaderTypeId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion


    }
}
