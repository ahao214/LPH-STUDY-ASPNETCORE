using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerDAL.Helper;
using JokerBooksManagerModels.Model;


namespace JokerBooksManagerDAL.BookDAL
{
    /// <summary>
    /// 数据库访问层读者类别
    /// </summary>
    public class ReaderTypeDAL
    {
        #region 新增读者类别

        /// <summary>
        /// 新增读者类别
        /// </summary>
        /// <param name="readerType">读者类别</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool AddReaderType(ReaderType readerType)
        {
            StringBuilder sb = new StringBuilder();
            BookCommandType commandType = BookCommandType.Text;
            sb.Append("INSERT INTO ReaderType(ReadTypeName)VALUES(@ReadTypeName)");
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReadTypeName",readerType .ReadTypeName)
            };
            try
            {
                return DBHelper.ExecuteNoneQuery(sb.ToString(), commandType, paras) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 读者类别是否存在

        /// <summary>
        /// 读者类别是否存在
        /// </summary>
        /// <param name="readerType">读者类别</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public static bool IsExistReaderType(string typeName)
        {
            bool res = false;
            StringBuilder sb = new StringBuilder();
            BookCommandType commandType = BookCommandType.Text;
            sb.Append("SELECT Count(*) FROM ReaderType WHERE ReadTypeName=@ReadTypeName");
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReadTypeName",typeName)
            };
            try
            {
                object obj = DBHelper.ExecuteScalar(sb.ToString(), commandType, paras);
                res = obj.ChangeInt() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

        #endregion

        #region 获取所有读者类别

        /// <summary>
        /// 获取所有读者类别
        /// </summary>
        /// <returns></returns>
        public static List<ReaderType> GetReaderTypes()
        {
            BookCommandType bookCommand = BookCommandType.Text;
            List<ReaderType> lst = new List<ReaderType>();
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT ReadTypeId,ReadTypeName FROM ReaderType  ORDER BY ReadTypeId ASC");
            DataTable dt = DBHelper.GetDataTable(sb.ToString(), bookCommand);
            foreach (DataRow dr in dt.Rows)
            {
                ReaderType type = new ReaderType
                {
                    ReadTypeId = dr["ReadTypeId"].ChangeInt(),
                    ReadTypeName = dr["ReadTypeName"].ToString()
                };
                lst.Add(type);
            }
            return lst;
        }


        #endregion

        #region 根据ID获取读者类别

        /// <summary>
        /// 根据ID获取读者类别
        /// </summary>
        /// <param name="ID">读者类别ID</param>
        /// <returns>返回读者类别对象</returns>
        public static ReaderType GetReaderTypeById(int ID)
        {
            ReaderType type = new ReaderType();
            BookCommandType bookCommand = BookCommandType.Text; StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT ReadTypeId,ReadTypeName FROM ReaderType WHERE ReadTypeId=@ReadTypeId  ORDER BY ReadTypeId ASC");
            DataTable dt = DBHelper.GetDataTable(sb.ToString(), bookCommand);
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReadTypeId",ID )
            };
            SqlDataReader dr = DBHelper.ExecuteReader(sb.ToString(), bookCommand, paras);
            if (dr.Read())
            {
                type = new ReaderType()
                {
                    ReadTypeId = dr["ReadTypeId"].ChangeInt(),
                    ReadTypeName = dr["ReadTypeName"].ToString()
                };
            }
            dr.Close();
            return type;
        }


        #endregion


    }
}
