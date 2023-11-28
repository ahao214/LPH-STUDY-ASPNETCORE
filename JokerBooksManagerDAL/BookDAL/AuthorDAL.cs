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
    /// 数据访问层：作者
    /// </summary>
    public class AuthorDAL
    {

        #region 新增出版社

        /// <summary>
        /// 新增出版社
        /// </summary>
        /// <param name="publishHouse">出版社</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool AddPublishHouse(PublishHouse publishHouse)
        {
            BookCommandType commandType = BookCommandType.Text;
            string sql = BuilderSqlHelper.InsertSql<PublishHouse>(publishHouse, "PublishHouse", "PublishId");
            return DBHelper.ExecuteNoneQuery(sql, commandType) > 0;
        }

        #endregion

        #region 出版社是否存在

        /// <summary>
        /// 出版社是否存在
        /// </summary>
        /// <param name="typeName">出版社</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public static bool IsExistPublishHouse(string typeName)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("PublishName", typeName);
            BookCommandType commandType = BookCommandType.Text;
            PublishHouse publishHouse = new PublishHouse();
            string sql = BuilderSqlHelper.SelectSql<PublishHouse>(publishHouse, "PublishHouse", "PublishId", dic);

            return DBHelper.GetDataTable(sql, commandType).DefaultView.Count > 0;
        }

        #endregion

        #region 获取所有出版社

        /// <summary>
        /// 获取所有出版社
        /// </summary>
        /// <returns></returns>
        public static List<PublishHouse> GetPublishHouses()
        {
            BookCommandType bookCommand = BookCommandType.Text;
            List<PublishHouse> lst = new List<PublishHouse>();
            StringBuilder sb = new StringBuilder();
            PublishHouse publishHouse = new PublishHouse();
            string sql = BuilderSqlHelper.SelectSql<PublishHouse>(publishHouse, "PublishHouse", "PublishId");

            SqlDataReader dr = DBHelper.ExecuteReader(sql, bookCommand);
            while (dr.Read())
            {
                PublishHouse type = new PublishHouse
                {
                    PublishId = dr["PublishId"].ChangeInt(),
                    PublishName = dr["PublishName"].ToString(),
                    Remark = dr["Remark"].ToString()
                };
                lst.Add(type);
            }
            dr.Close();

            return lst;
        }


        #endregion

        #region 根据ID获取出版社

        /// <summary>
        /// 根据ID获取出版社
        /// </summary>
        /// <param name="ID">出版社ID</param>
        /// <returns>返回出版社对象</returns>
        public static PublishHouse GetPublishHouseById(int ID)
        {
            PublishHouse house = new PublishHouse();
            BookCommandType bookCommand = BookCommandType.Text;
            Dictionary<string, object> dic = new Dictionary<string, object>
            {
                { "PublishId",ID }
            };
            string sql = BuilderSqlHelper.SelectSql<PublishHouse>(house, "PublishHouse", "PublishId", dic);
            SqlDataReader dr = DBHelper.ExecuteReader(sql, bookCommand);
            if (dr.Read())
            {
                house = new PublishHouse
                {
                    PublishName = dr["PublishName"].ToString(),
                    Remark = dr["Remark"].ToString()
                };
            }
            dr.Close();
            return house;
        }


        #endregion


        #region 更新出版社

        /// <summary>
        /// 更新出版社
        /// </summary>
        /// <param name="PublishHouse">出版社对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool UpdatePublishHouse(PublishHouse publishHouse)
        {
            BookCommandType commandType = BookCommandType.Text;
            string sql = BuilderSqlHelper.UpdateSql<PublishHouse>(publishHouse, "PublishHouse", "PublishId", publishHouse.PublishId);

            return DBHelper.ExecuteNoneQuery(sql, commandType) > 0;

        }

        #endregion



        #region 删除出版社

        /// <summary>
        /// 删除出版社
        /// </summary>
        /// <param name="iPublishHouseId">出版社ID</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool DeletePublishHouse(int publishId)
        {
            BookCommandType commandType = BookCommandType.Text;
            List<string> sqlList = new List<string>();
            StringBuilder sb = new StringBuilder();
            PublishHouse publishHouse = new PublishHouse();
            publishHouse.PublishId = publishId;

            string sql = BuilderSqlHelper.DeleteSql<PublishHouse>(publishHouse, "PublishHouse", "PublishId");
            sb.Append(sql);
            sqlList.Add(sb.ToString());
            return DBHelper.ExecuteSqlTrans(sqlList, commandType);

        }

        #endregion


    }
}
