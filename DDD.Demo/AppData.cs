using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Demo.Domain.Model;
namespace DDD.Demo
{
    /// <summary>
    /// 
    /// </summary>
    public class AppData : ObservableObject
    {
        public static AppData Instance = new Lazy<AppData>(() => new AppData()).Value;

        public MemberModel CurrentUser { get; set; } = new MemberModel();


    }
}
