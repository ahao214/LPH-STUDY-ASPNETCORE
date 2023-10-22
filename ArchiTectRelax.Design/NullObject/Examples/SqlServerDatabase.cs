using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.NullObject.Examples
{
     class SqlServerDatabase: AbstractDatabase
    {
        public SqlServerDatabase(string name)
        {
            this.DatabaseName = name;
        }
        public override string GetURL()
        {
            return "sqlserver数据库的url";
        }
    }
}
