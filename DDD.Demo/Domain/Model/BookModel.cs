using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Domain.Model
{
    /// <summary>
    /// 图书模型
    /// </summary>
    public class BookModel
    {
        private int id = 0;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
