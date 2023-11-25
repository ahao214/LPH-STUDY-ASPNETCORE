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
    /// 业务逻辑层读者信息
    /// </summary>
    public class ReaderInfoBLL
    {
        #region 新增读者信息

        /// <summary>
        /// 新增读者信息
        /// </summary>
        /// <param name="info">读者对象</param>
        /// <returns>True：成功 False：失败</returns>
        public bool AddReaderInfo(ReaderInfo info)
        {
            try
            {
                return ReaderInfoDAL.AddReaderInfo(info);
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

        #region 获取读者编码中最后一条读者编码
        /// <summary>
        /// 获取读者编码中最后一条读者编码
        /// </summary>
        /// <returns>返回读者编码</returns>
        public string GetReaderNumber()
        {
            try
            {
                return ReaderInfoDAL.GetReaderNumber();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion
    }
}
