using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Domain.Model
{
    /// <summary>
    /// 会员模型
    /// </summary>
    public class MemberModel
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime? insertDate;
        public DateTime? InsertDate
        {
            get { return insertDate; }
            set { insertDate = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
