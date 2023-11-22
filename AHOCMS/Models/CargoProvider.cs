using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHOCMS.Models;

namespace Models
{
    public class CargoProvider : IProvider<Cargo>
    {
        private CargoDBEntities db = new CargoDBEntities();

        public int Delete(Cargo t)
        {
            if (t == null) return 0;
            var model = db.Cargo.ToList().FirstOrDefault(item => item.Id == t.Id);
            if (model == null) return 0;
            db.Cargo.Remove(model);
            int count = db.SaveChanges();
            return count;
        }

        public int Insert(Cargo t)
        {
            if (t == null)
                return 0;
            if (t.InsertDate == null)
                return 0;
            db.Cargo.Add(t);
            int count = db.SaveChanges();
            return count;
        }

        public List<Cargo> Select()
        {
            return db.Cargo.ToList();
        }

        public int Update(Cargo t)
        {
            throw new NotImplementedException();
        }
    }
}
