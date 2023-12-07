using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Demo.Model;


namespace DDD.Demo.Dao
{
    /// <summary>
    /// 读者方法
    /// </summary>
    public class ReaderProvider : IProvider<Reader>
    {
        public int Delete(Reader t)
        {
            throw new NotImplementedException();
        }

        public int Insert(Reader t)
        {
            throw new NotImplementedException();
        }

        public List<Reader> Select()
        {
            throw new NotImplementedException();
        }

        public Reader Select(int Id)
        {
            throw new NotImplementedException();
        }

        public int Update(Reader t)
        {
            throw new NotImplementedException();
        }
    }
}
