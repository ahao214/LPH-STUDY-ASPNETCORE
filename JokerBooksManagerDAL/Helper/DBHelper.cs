﻿using System;
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


        #region 返回首行首列

        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="iCmdType">命令类型</param>
        /// <param name="param">参数列表</param>
        /// <returns>返回首行首列</returns>
        public static object ExecuteScalar(string sql, BookCommandType iCmdType, params SqlParameter[] param)
        {
            object res = null;
            using (SqlConnection conn = CreateConn())
            {
                SqlCommand cmd = CreateCommand(conn, sql, iCmdType, null, param);
                res = cmd.ExecuteScalar();//返回一个值 第一行第一列
                cmd.Parameters.Clear();
                if (res is null || res == DBNull.Value)
                {
                    res = null;
                }
            }
            return res;
        }

        #endregion


        #region 执行带事务的SQL语句

        /// <summary>
        /// 执行带事务的SQL语句
        /// </summary>
        /// <param name="listSql">SQL语句集合</param>
        /// <param name="iCmdType">命令类型</param>
        /// <param name="param">参数</param>
        /// <returns>True:成功 False：失败</returns>
        public static bool ExecuteSqlTrans(List<string> listSql, BookCommandType iCmdType, params SqlParameter[] param)
        {
            using (SqlConnection conn = CreateConn())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {                    
                    SqlCommand cmd = CreateCommand(conn, "", iCmdType, trans, param);
                    int count = 0;
                    for (int i = 0; i < listSql.Count; i++)
                    {
                        if (listSql[i].Length > 0)
                        {
                            cmd.CommandText = listSql[i];
                            cmd.CommandType = CommandType.Text;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();   //回滚事务
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        #endregion

    }
}
