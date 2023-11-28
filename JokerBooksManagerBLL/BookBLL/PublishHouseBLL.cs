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
    /// 业务逻辑层：出版社信息
    /// </summary>
    public class PublishHouseBLL
    {
        #region 新增出版社

        /// <summary>
        /// 新增出版社
        /// </summary>
        /// <param name="readerType">出版社</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool AddPublishHouse(PublishHouse publishHouse)
        {
            try
            {
                return PublishHouseDAL.AddPublishHouse(publishHouse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 出版社是否重复

        /// <summary>
        /// 出版社是否存在
        /// </summary>
        /// <param name="readerType">出版社</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public bool IsExistPublishHouse(string typeName)
        {
            try
            {
                return PublishHouseDAL.IsExistPublishHouse(typeName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 获取所有出版社

        /// <summary>
        /// 获取所有出版社
        /// </summary>
        /// <returns>返回图书对象集合</returns>
        public List<PublishHouse> GetPublishHouses()
        {
            try
            {
                return PublishHouseDAL.GetPublishHouses();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion


        #region 根据ID获取出版社

        /// <summary>
        /// 根据ID获取出版社
        /// </summary>
        /// <param name="ID">出版社ID</param>
        /// <returns>返回出版社对象</returns>
        public PublishHouse GetPublishHouseById(int ID)
        {
            try
            {
                return PublishHouseDAL.GetPublishHouseById(ID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion


        #region 更新出版社

        /// <summary>
        /// 更新出版社
        /// </summary>
        /// <param name="readerType">出版社对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public bool UpdatePublishHouse(PublishHouse publishHouse)
        {
            try
            {
                return PublishHouseDAL.UpdatePublishHouse(publishHouse);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region 删除出版社

        /// <summary>
        /// 删除出版社
        /// </summary>
        /// <param name="readerType">出版社ID</param>
        /// <returns>大于0：True 小于0：False</returns>
        public bool DeletePublishHouse(int id)
        {
            try
            {
                return PublishHouseDAL.DeletePublishHouse(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion


    }
}
