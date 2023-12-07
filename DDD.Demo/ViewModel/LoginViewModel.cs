using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

    }
}
