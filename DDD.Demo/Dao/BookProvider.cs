using System;
using System.Collections.Generic;
using DDD.Demo.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Dao
{
    /// <summary>
    /// 图书类方法
    /// </summary>
    public class BookProvider : IProvider<Book>
    {
        public int Delete(Book t)
        {
            throw new NotImplementedException();
        }

        public int Insert(Book t)
        {
            throw new NotImplementedException();
        }

        public List<Book> Select()
        {
            throw new NotImplementedException();
        }

        public Book Select(int Id)
        {
            throw new NotImplementedException();
        }

        public int Update(Book t)
        {
            throw new NotImplementedException();
        }
    }
}
