using DDD.Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Dao
{
    /// <summary>
    /// 会员类的方法
    /// </summary>
    public class MemberProvider : IProvider<Member>
    {
        public int Delete(Member t)
        {
            using (BookDBEntities db = new BookDBEntities())
            {
                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();
            }
        }

        public int Insert(Member t)
        {
            using (BookDBEntities db = new BookDBEntities())
            {
                db.Entry(t).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges();
            }
        }

        public List<Member> Select()
        {
            using (BookDBEntities db = new BookDBEntities())
            {
                return db.Member.ToList();

            }
        }

        public Member Select(int Id)
        {
            using (BookDBEntities db = new BookDBEntities())
            {
                var lst = db.Member.Where(item => item.Id == Id).ToList();
                if (lst.Count == 0)
                    return new Member();
                else
                    return lst[0];
            }
        }

        public int Update(Member t)
        {
            using (BookDBEntities db = new BookDBEntities())
            {
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        }
    }
}
