using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHOCMS.Models;

namespace Models
{
    public class MemberProvider : IProvider<Member>
    {
        private CargoDBEntities db = new CargoDBEntities();

        public int Delete(Member t)
        {
            if (t == null) return 0;
            var model = db.Member.ToList().FirstOrDefault(item => item.Id == t.Id);
            if (model == null) return 0;
            db.Member.Remove(model);
            int count = db.SaveChanges();
            return count;
        }

        public int Insert(Member t)
        {
            if (t == null)
                return 0;
            if (t.InsertDate == null)
                return 0;
            db.Member.Add(t);
            int count = db.SaveChanges();
            return count;
        }

        public List<Member> Select()
        {
            return db.Member.ToList();
        }

        public int Update(Member t)
        {
            if (t == null)
                return 0;
            var model = db.Member.ToList().FirstOrDefault(item => t.Id == item.Id);
            if (model == null) return 0;
            
            int count = db.SaveChanges();
            return count;
        }
    }
}
