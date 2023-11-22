using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHOCMS.Models;
using GalaSoft.MvvmLight;


namespace AHOCMS
{
    public class AppData : ObservableObject
    {
        public static AppData Instance = new Lazy<AppData>(() => new AppData()).Value;

        private string systemName = "仓库物资管理系统 1.0";

        public string SystemName
        {
            get { return systemName; }
            set { systemName = value; RaisePropertyChanged(); }
        }


        private Member member = new Member();

        public Member CurrentUser
        {
            get { return member; }
            set { member = value; RaisePropertyChanged("CurrentUser"); }
        }

        /// <summary>
        ///  主窗体
        /// </summary>
        public MainWindow MainWindow { get; set; } = null;

        /// <summary>
        /// 显示或者隐藏遮罩层
        /// </summary>
        /// <param name="isMark"></param>
        public void ShowMarkLayer(bool isMark)
        {
            if(MainWindow ==null)
            {
                return;
            }
            MainWindow.markLayer.Visibility = isMark ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
        }

    }
}
