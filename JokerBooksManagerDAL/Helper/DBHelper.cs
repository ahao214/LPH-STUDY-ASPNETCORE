using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using JokerBooksManagerComm.Comm;
using System.Runtime.InteropServices.WindowsRuntime;



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
        public static DataTable GetDataTable(string sql, BookCommandType iCmdType, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = CreateConn())
            {
                SqlCommand cmd = CreateCommand(conn, sql, iCmdType, null, parameters);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            return dt;
        }

        #endregion

        #region 返回SqlCommand对象

        /// <summary>
        /// 返回SqlCommand对象
        /// </summary>
        /// <param name="oConn"></param>
        /// <param name="sql"></param>
        /// <param name="iCmdType"></param>
        /// <param name="trans"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static SqlCommand CreateCommand(SqlConnection oConn, string sql, BookCommandType iCmdType, SqlTransaction trans, params SqlParameter[] paras)
        {
            // iCmdType 1是Text 2是StoredProcedure 3是Table
            if (oConn == null)
            {
                throw new Exception(CommConst.ConnNotNull);
            }
            SqlCommand cmd = new SqlCommand(sql, oConn);
            if (iCmdType.ChangeInt() == 2)
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

        #region 返回SqlDataReader对象

        /// <summary>
        /// 返回SqlDataReader对象
        /// </summary>
        /// <param name="sql">SQL一句</param>
        /// <param name="iCmdType">命令类型</param>
        /// <param name="param">参数</param>
        /// <returns>返回SqlDataReader对象</returns>
        public static SqlDataReader ExecuteReader(string sql, BookCommandType iCmdType, params SqlParameter[] param)
        {
            SqlConnection conn = CreateConn();
            SqlCommand cmd = CreateCommand(conn, sql, iCmdType, null, param);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        #endregion

        #region 执行增删改命令

        /// <summary>
        /// 执行增删改命令
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="iCmdType">命令类型</param>
        /// <param name="param">参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNoneQuery(string sql, BookCommandType iCmdType, params SqlParameter[] param)
        {
            int res = 0;
            using (SqlConnection conn = CreateConn())
            {
                SqlCommand cmd = CreateCommand(conn, sql, iCmdType, null, param);
                res = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            return res;
        }

        #endregion

    }
}
