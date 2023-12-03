using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.Model.Provider
{
    /// <summary>
    /// 子线类型模型方法
    /// </summary>
    public class SubLineProvider : IProvider<SubLine>
    {
        private readonly BoardDBEntities db = new BoardDBEntities();
        public int Delete(SubLine t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }

        public int Insert(SubLine t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public List<SubLine> Select()
        {
            return db.SubLine.Include("History").ToList();
        }

        public int Update(SubLine t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
