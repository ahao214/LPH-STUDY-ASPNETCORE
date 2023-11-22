using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using AHOCMS.Models;
using Models;
using GalaSoft.MvvmLight.Command;
using AHOCMS.Windows;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;

namespace AHOCMS.ViewModel
{
    public class CargoTypeViewModel : ViewModelBase
    {
        private List<CargoType> cargoTypes = new List<CargoType>();

        /// <summary>
        /// 所有物资类型
        /// </summary>
        public List<CargoType> CargoTypes
        {
            get
            {
                return cargoTypes;
            }
            set
            {
                cargoTypes = value;
                RaisePropertyChanged();
            }
        }

        public CargoTypeViewModel()
        {
            cargoTypes = new CargoTypeProvider().Select();
        }

        /// <summary>
        /// 打开物资类型添加页面
        /// </summary>
        public RelayCommand OpenAddCargoTypeWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var window = new AddCargoTypeWindow();
                    window.ShowDialog();
                    // 刷新数据库
                    CargoTypes = new CargoTypeProvider().Select();
                });
            }
        }

        /// <summary>
        /// 删除物资类型
        /// </summary>
        public RelayCommand <object> DeleteCargoTypeCommand
        {
            get
            {
                return new RelayCommand<object>((arg) =>
                {
                    if(!(arg is CargoType model))
                        return;
                    var count = new CargoTypeProvider().Delete(model);
                    if(count> 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    // 刷新数据库
                    CargoTypes = new CargoTypeProvider().Select();
                });
            }
        }
    }
}
