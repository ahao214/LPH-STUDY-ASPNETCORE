using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataBoard.Entities
{
    public class RoleModel
    {
        private int id;
        /// <summary>
        /// 角色ID
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
