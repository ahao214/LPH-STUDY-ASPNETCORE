using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHOCMS.Models;

namespace Models
{
    public class RecordProvider : IProvider<Record>
    {
        private CargoDBEntities db = new CargoDBEntities();
        public int Delete(Record t)
        {
            if (t == null) return 0;
            var model = db.Record.ToList().FirstOrDefault(item => item.Id == t.Id);
            if (model == null) return 0;
            db.Record.Remove(model);
            int count = db.SaveChanges();
            return count;
        }

        public int Insert(Record t)
        {
            if (t == null)
                return 0;
            if (t.InsertDate == null)
                return 0;
            db.Record.Add(t);
            int count = db.SaveChanges();
            return count;
        }

        public List<Record> Select()
        {
            return db.Record.ToList();
        }

        public int Update(Record t)
        {
            throw new NotImplementedException();
        }
    }
}
