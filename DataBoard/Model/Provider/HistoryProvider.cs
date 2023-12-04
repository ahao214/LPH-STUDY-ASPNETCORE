using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.Model.Provider
{
    /// <summary>
    /// 停机数据类型模型方法  
    /// </summary>
    public class HistoryProvider : IProvider<History>
    {
        private readonly BoardDBEntities db = new BoardDBEntities();
        public int Delete(History t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }

        public int Insert(History t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public List<History> Select()
        {
            return db.History.Include("Line").Include("StopType").Include("SubLine").Include("UserInfo").ToList();
        }

        public int Update(History t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
