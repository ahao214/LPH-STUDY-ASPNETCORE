using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHOCMS.Models;

namespace Models
{
    /// <summary>
    /// 类型设置
    /// </summary>
    public class CargoTypeProvider : IProvider<CargoType>
    {
        private CargoDBEntities db = new CargoDBEntities();

        public int Delete(CargoType t)
        {
            if (t == null)
                return 0;
            db.CargoType.Remove(t);
            
            int count = db.SaveChanges();
            return count;            
        }

        public int Insert(CargoType t)
        {
            if (t == null)
                return 0;
            if (string.IsNullOrEmpty(t.Name) || string.IsNullOrEmpty(t.MemberName))
                return 0;
            if (t.InsertDate == null)
                return 0;
            db.CargoType.Add(t);
            int count = db.SaveChanges();
            return count;
        }

        public List<CargoType> Select()
        {
            return db.CargoType.ToList();
        }

        public int Update(CargoType t)
        {
            if (t == null)
                return 0;
            return 0;
        }
    }
}
