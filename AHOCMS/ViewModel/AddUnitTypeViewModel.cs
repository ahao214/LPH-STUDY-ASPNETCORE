using AHOCMS.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AHOCMS.ViewModel
{
    /// <summary>
    /// 单位信息
    /// </summary>
    public class AddUnitTypeViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

        private UnitType unitTypes = new UnitType();

        public UnitType UnitType
        {
            get { return unitTypes; }
            set
            {
                unitTypes = value; RaisePropertyChanged();
            }
        }



        /// <summary>
        /// 关闭窗体
        /// </summary>
        public RelayCommand<Window> CloseCommand
        {
            get
            {
                return new RelayCommand<Window>((arg) =>
                {
                    if (arg == null)
                        return;
                    arg.Close();
                });
            }
        }

        #region 添加新的单位类型
        /// <summary>
        /// 添加新的单位类型
        /// </summary>
        public RelayCommand<Window> AddUnitTypeCommand
        {
            get
            {
                return new RelayCommand<Window>((arg) =>
                {
                    if (string.IsNullOrEmpty(unitTypes.Name))
                        return;
                    unitTypes.InsertDate = DateTime.Now;
                    unitTypes.MemberId = AppData.CurrentUser.Id;
                    unitTypes.MemberName = AppData.CurrentUser.Name;
                    var count = new UnitTypeProvider().Insert(unitTypes);
                    if (count == 0)
                    {
                        MessageBox.Show("添加失败");
                    }
                    else
                    {
                        arg.Close();
                    }
                });
            }
        } 
        #endregion

    }
}
