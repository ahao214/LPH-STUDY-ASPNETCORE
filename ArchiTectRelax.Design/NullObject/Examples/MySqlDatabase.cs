using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.NullObject.Examples
{

    /// <summary>
    /// mysql数据库
    /// </summary>
    public class MySqlDatabase : AbstractDatabase
    {
        public MySqlDatabase(string name)
        {
            this.DatabaseName = name;
        }
        public override string GetURL()
        {
            return "mysql数据库的url";
        }
    }
}
