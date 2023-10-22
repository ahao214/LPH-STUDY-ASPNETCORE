using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.NullObject.Examples
{
     class OarcleDatabase: AbstractDatabase
    {
        public OarcleDatabase(string name)
        {
            this.DatabaseName = name;
        }
        public override string GetURL()
        {
            return "Oarcle数据库的url";
        }
    }
}
