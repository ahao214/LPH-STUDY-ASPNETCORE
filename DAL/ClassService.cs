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

        /// <summary>
        /// 根据班级名称查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public StudentClass GetClassObject(string name)
        {
            string sql = $"select Id,ClassName from StudentClass where ClassName={name}";
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

    }
}
