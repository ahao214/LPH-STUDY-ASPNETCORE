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
    }
}
