using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.Model.Provider
{
    /// <summary>
    /// 停机类型模型方法
    /// </summary>
    public class StopTypeProvider : IProvider<StopType>
    {
        private readonly BoardDBEntities db = new BoardDBEntities();
        public int Delete(StopType t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }

        public int Insert(StopType t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public List<StopType> Select()
        {
            return db.StopType.Include("History").Include("UserInfo").ToList();
        }

        public int Update(StopType t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
