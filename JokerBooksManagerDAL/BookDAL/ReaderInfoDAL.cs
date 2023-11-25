using JokerBooksManagerComm.Comm;
using JokerBooksManagerDAL.Helper;
using JokerBooksManagerModels.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerDAL.BookDAL
{
    /// <summary>
    /// 数据库访问层读者信息
    /// </summary>
    public class ReaderInfoDAL
    {
        #region 新增读者信息

        /// <summary>
        /// 新增读者信息
        /// </summary>
        /// <param name="readerType">读者类</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool AddReaderType(ReaderType readerType)
        {
            StringBuilder sb = new StringBuilder();
            BookCommandType commandType = BookCommandType.Text;
            sb.Append("INSERT INTO ReaderType(ReaderTypeName)VALUES(@ReaderTypeName)");

            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeName",readerType .ReaderTypeName)
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

        #region 读者是否存在

        /// <summary>
        /// 读者是否存在
        /// </summary>
        /// <param name="readerType">读者类别</param>
        /// <returns>大于0：成功 小于0：失败</returns>
        public static bool IsExistReaderType(string typeName)
        {
            bool res = false;
            StringBuilder sb = new StringBuilder();
            BookCommandType commandType = BookCommandType.Text;
            sb.Append("SELECT Count(*) FROM ReaderType WHERE ReaderTypeName=@ReaderTypeName");
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeName",typeName)
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

        #region 返回读者信息集合

        /// <summary>
        /// 返回读者信息集合
        /// </summary>
        /// <returns></returns>
        public static List<ReaderInfoExpend> GetReaderInfos()
        {
            BookCommandType bookCommand = BookCommandType.Text;
            List<ReaderInfoExpend> lst = new List<ReaderInfoExpend>();
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT R.ReaderId,R.ReaderTypeId,R.ReaderName,R.ReaderSex,R.ReaderNumber,R.ReaderIdCard,R.ReaderTel,R.ReaderRemark,T.ReaderTypeName FROM ReaderInfo AS R,ReaderType AS T WHERE R.ReaderTypeId = T.ReaderTypeId  ORDER BY R.ReaderId ASC");
            DataTable dt = DBHelper.GetDataTable(sb.ToString(), bookCommand);
            foreach (DataRow dr in dt.Rows)
            {
                ReaderInfoExpend readerInfo = new ReaderInfoExpend
                {
                    ReaderId = dr["ReaderId"].ChangeInt(),
                    ReaderTypeName = dr["ReaderTypeName"].ToString(),
                    ReaderTypeId = dr["ReaderTypeId"].ChangeInt(),
                    ReaderName = dr["ReaderName"].ToString(),
                    ReaderSex = dr["ReaderSex"].ToString(),
                    ReaderNumber = dr["ReaderNumber"].ToString(),
                    ReaderIdCard = dr["ReaderIdCard"].ToString(),
                    ReaderTel = dr["ReaderTel"].ToString(),
                    ReaderRemark = dr["ReaderName"].ToString()
                };
                lst.Add(readerInfo);
            }
            return lst;
        }


        #endregion

        #region 根据ID获取读者

        /// <summary>
        /// 根据ID获取读者
        /// </summary>
        /// <param name="ID">读者ID</param>
        /// <returns>返回读者对象</returns>
        public static ReaderType GetReaderTypeById(int ID)
        {
            ReaderType type = new ReaderType();
            BookCommandType bookCommand = BookCommandType.Text; StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT ReaderTypeId,ReaderTypeName FROM ReaderType WHERE ReaderTypeId=@ReaderTypeId");
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeId",ID )
            };
            SqlDataReader dr = DBHelper.ExecuteReader(sb.ToString(), bookCommand, paras);
            if (dr.Read())
            {
                type = new ReaderType()
                {
                    ReaderTypeId = dr["ReaderTypeId"].ChangeInt(),
                    ReaderTypeName = dr["ReaderTypeName"].ToString()
                };
            }
            dr.Close();
            return type;
        }


        #endregion


        #region 更新读者

        /// <summary>
        /// 更新读者
        /// </summary>
        /// <param name="readerType">读者对象</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool UpdateReaderType(ReaderType readerType)
        {
            BookCommandType commandType = BookCommandType.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("Update ReaderType SET ReaderTypeName=@ReaderTypeName WHERE ReaderTypeId=@ReaderTypeId");
            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeName",readerType.ReaderTypeName),
                new SqlParameter ("@ReaderTypeId",readerType.ReaderTypeId)
            };
            return DBHelper.ExecuteNoneQuery(sb.ToString(), commandType, paras) > 0;

        }

        #endregion



        #region 删除读者

        /// <summary>
        /// 删除读者
        /// </summary>
        /// <param name="readerType">读者ID</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool DeleteReaderType(int iReaderTypeId)
        {
            BookCommandType commandType = BookCommandType.Text;
            List<string> sqlList = new List<string>();

            StringBuilder sb = new StringBuilder();
            sb.Append("Delete From  ReaderInfo WHERE ReaderTypeId=@ReaderTypeId");
            sqlList.Add(sb.ToString());
            sb.Clear();
            sb.Append("Delete From  ReaderType WHERE ReaderTypeId=@ReaderTypeId");
            sqlList.Add(sb.ToString());


            SqlParameter[] paras =
            {
                new SqlParameter ("@ReaderTypeId",iReaderTypeId)
            };

            return DBHelper.ExecuteSqlTrans(sqlList, commandType, paras);

        }

        #endregion


        #region 获取读者编码中最后一条读者编码
        /// <summary>
        /// 获取读者编码中最后一条读者编码
        /// </summary>
        /// <returns>返回读者编码</returns>
        public static string GetReaderNumber()
        {
            BookCommandType iCmdType = BookCommandType.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TOP 1 ReaderNumber FROM ReaderInfo ORDER BY ReaderId DESC");
            SqlDataReader reader = DBHelper.ExecuteReader(sb.ToString(), iCmdType);
            string sReaderNumber;
            if(reader.Read ())
            {
                sReaderNumber = reader["ReaderNumber"].ToString();
            }
            else
            {
                sReaderNumber = "RU00000000000";
            }
            reader.Close();
            return sReaderNumber;
        }


        #endregion

    }
}
