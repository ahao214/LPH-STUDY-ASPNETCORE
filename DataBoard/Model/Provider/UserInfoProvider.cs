using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.Model.Provider
{
    /// <summary>
    /// 用户模型方法
    /// </summary>
    public class UserInfoProvider : IProvider<UserInfo>
    {
        public int Delete(UserInfo t)
        {
            using (BoardDBEntities db = new BoardDBEntities())
            {
                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();
            }
        }

        public int Insert(UserInfo t)
        {
            using (BoardDBEntities db = new BoardDBEntities())
            {
                db.Entry(t).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges();
            }
        }

        public List<UserInfo> Select()
        {
            using (BoardDBEntities db = new BoardDBEntities())
            {
                return db.UserInfo.Include("History").Include("UserInfo").ToList();
            }
        }

        public int Update(UserInfo t)
        {
            using (BoardDBEntities db = new BoardDBEntities())
            {
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        }
    }
}
