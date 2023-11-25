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
    /// 数据访问层读者信息
    /// </summary>
    public class ReaderInfoDAL
    {
        #region 新增读者信息

        /// <summary>
        /// 新增读者信息
        /// </summary>
        /// <param name="readerType">读者类</param>
        /// <returns>大于0：True 小于0：False</returns>
        public static bool AddReaderInfo(ReaderInfo info)
        {
            BookCommandType commandType = BookCommandType.Text;

            // 获取SQL语句
            string sql = BuilderSqlHelper.InsertSql<ReaderInfo>(info, "ReaderInfo", "ReaderId");
            return DBHelper.ExecuteNoneQuery(sql, commandType) > 0;
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
            if (reader.Read())
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

        #region 




        #endregion





       


        

    }
}
