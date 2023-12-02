using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.Model.Provider
{
    /// <summary>
    /// 生产线模型方法
    /// </summary>
    public class LineProvider : IProvider<Line>
    {
        private readonly BoardDBEntities db = new BoardDBEntities();
        public int Delete(Line t)
        {
            if (t == null)
                return 0;
            var model = db.Line.ToList().FirstOrDefault(item => item.Id == t.Id);
            if (model == null) return 0;
            db.Line.Remove(model);
            return db.SaveChanges();
        }

        public int Insert(Line t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }

        public List<Line> Select()
        {
            return db.Line.Include("UserInfo").ToList();
        }

        public int Update(Line t)
        {
            throw new NotImplementedException();
        }
    }
}
