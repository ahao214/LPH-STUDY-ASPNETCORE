using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuModels;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{

    /// <summary>
    /// 班级数据访问类
    /// 写班级的CURD方法
    /// </summary>
    public class ClassService
    {
        #region 返回班级列表

        /// <summary>
        /// 返回班级列表
        /// </summary>
        /// <returns></returns>
        public List<StudentClass> ClassList()
        {
            string sql = "select Id,ClassName from StudentClass";
            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            List<StudentClass> classList = new List<StudentClass>();
            while (reader.Read())
            {
                classList.Add(new StudentClass()
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    ClassName = reader["ClassName"].ToString()
                });
            }
            return classList;
        }

        #endregion

        #region 根据班级ID查询

        /// <summary>
        /// 根据班级ID查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StudentClass GetClassObject(int id)
        {
            string sql = $"select Id,ClassName from StudentClass where Id={id}";
            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            StudentClass objClass = new StudentClass();
            while (reader.Read())
            {
                objClass = new StudentClass()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    ClassName = reader["ClassName"].ToString()
                };
            }
            return objClass;
        }

        #endregion

        #region 根据班级名称查询

        /// <summary>
        /// 根据班级名称查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StudentClass GetClassObject(string className)
        {
            string sql = $"select Id,ClassName from StudentClass where ClassName={className}";
            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            StudentClass objClass = new StudentClass();
            while (reader.Read())
            {
                objClass = new StudentClass()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    ClassName = reader["ClassName"].ToString()
                };
            }
            return objClass;
        }

        #endregion

        #region 删除班级

        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteClass(int id)
        {
            string sql = $"Delete from StudentClass Where Id={id}";
            int result = SQLHelper.GetSingle(sql);
            return result > 0;
        }

        #endregion

        #region 修改班级

        /// <summary>
        /// 修改班级名称
        /// </summary>
        /// <param name="id"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public bool UpdateClass(int id, string className)
        {
            string sql = $"update StudentClass set ClassName=N'{className}' where Id={id}";
            int result = SQLHelper.GetSingle(sql);
            return result > 0;
        }

        #endregion

    }
}
