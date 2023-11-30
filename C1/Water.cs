using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    public delegate void WaterDelegate();

    public class Water
    {
        public void WaterAction(WaterDelegate wd)
        {
            wd.Invoke();
        }

    }
}
