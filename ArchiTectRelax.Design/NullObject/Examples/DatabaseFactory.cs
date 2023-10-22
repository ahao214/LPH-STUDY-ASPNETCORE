using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.NullObject.Examples
{
    class DatabaseFactory
    {
        public static string[] names = { "mysql", "sqlserver", "oarcle" };

        public static AbstractDatabase GetDatabase(string name)
        {
            if (names[0].Equals(name))
            {
                return new MySqlDatabase(name);
            }
            else if (names[1].Equals(name))
            {
                return new SqlServerDatabase(name);
            }
            else if (names[2].Equals(name))
            {
                return new OarcleDatabase(name);
            }
            else
            {
                return new NullDatabase("null");
            }
        }

    }
}
