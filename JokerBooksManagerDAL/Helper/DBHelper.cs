using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using JokerBooksManagerComm.Comm;



namespace JokerBooksManagerDAL.Helper
{
    /// <summary>
    /// DBHelper类用来封装数据库操作事情
    /// </summary>
    public class DBHelper : CommStaticClass
    {
        #region 创建数据库连接对象

        /// <summary>
        /// 创建数据库链接对象
        /// </summary>
        /// <returns></returns>
        private static SqlConnection CreateConn()
        {
            return new SqlConnection(ConnectionStrings);
        }

        #endregion

        #region 返回DataTable

        /// <summary>
        /// 返回DataTable
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="iCmdType">参数数组</param>
        /// <param name="parameters">返回DataTable</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, int iCmdType, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = CreateConn ())
            {
                SqlCommand cmd = CreateCommand(conn, sql, iCmdType, null, parameters);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            return dt;
        }

        #endregion

        #region

        private static SqlCommand CreateCommand(SqlConnection oConn, string sql, int iCmdType, SqlTransaction trans, params SqlParameter[] paras)
        {
            // iCmdType 1是Text 2是StoredProcedure 3是Table
            if (oConn == null)
            {
                throw new Exception(CommConst.ConnNotNull);
            }
            SqlCommand cmd = new SqlCommand(sql, oConn);
            if (iCmdType == 2)
            {
                // 是存储过程
                cmd.CommandType = CommandType.StoredProcedure;
            }
            if (oConn.State == ConnectionState.Closed)
            {
                oConn.Open();
            }
            if (trans != null)
            {
                cmd.Transaction = trans;  //如果有事务就赋值给SqlCommand
            }
            if (paras.Length > 0 && paras != null)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paras);
            }
            return cmd;
        }

        #endregion


    }
}
