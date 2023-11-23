using AHOCMS.Models;
using AHOCMS.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AHOCMS.ViewModel
{
    /// <summary>
    /// 单位信息
    /// </summary>
    public class UnitTypeViewModel:ViewModelBase
    {
        private List<UnitType> unitTypes = new List<UnitType>();

        /// <summary>
        /// 所有的单位类型
        /// </summary>
        public List<UnitType> UnitTypes
        {
            get
            {
                return unitTypes;
            }
            set
            {
                unitTypes = value;
                RaisePropertyChanged();
            }
        }

        public UnitTypeViewModel()
        {
            unitTypes = new UnitTypeProvider().Select();
        }

        /// <summary>
        /// 打开单位信息添加页面
        /// </summary>
        public RelayCommand OpenAddUnitTypeWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var window = new AddUnitTypeWindow();
                    window.ShowDialog();
                    // 刷新数据库
                    UnitTypes = new UnitTypeProvider().Select();
                });
            }
        }

        /// <summary>
        /// 删除单位信息
        /// </summary>
        public RelayCommand<object> DeleteUnitTypeCommand
        {
            get
            {
                return new RelayCommand<object>((arg) =>
                {
                    if (!(arg is UnitType model))
                        return;
                    var units = new CargoProvider().Select().FindAll(t => t.UnitId == model.Id);
                    if(units !=null && units.Count >0)
                    {
                        MessageBox.Show("当前单位已有在使用");
                        return;
                    }
                    var count = new UnitTypeProvider().Delete(model);
                    if (count > 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    // 刷新数据库
                    UnitTypes = new UnitTypeProvider().Select();
                });
            }
        }

    }
}
