using GalaSoft.MvvmLight;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOCMS.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {
        public Member Member { get; set; } = AppData.Instance.CurrentUser;



    }
}
