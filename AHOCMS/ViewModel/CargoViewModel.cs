using AHOCMS.Models;
using AHOCMS.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOCMS.ViewModel
{
    public class CargoViewModel:ViewModelBase
    {
        public CargoViewModel()
        {
            Cargos = new CargoProvider().Select();
        }

        private List<Cargo> cargos = new List<Cargo>();

        /// <summary>
        /// 所有物资
        /// </summary>
        public List <Cargo> Cargos
        {
            get
            {
                return cargos;
            }
            set
            {
                cargos = value;RaisePropertyChanged();
            }
        }


        /// <summary>
        /// 打开物资添加页面
        /// </summary>
        public RelayCommand OpenAddCargoWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var window = new AddCargoWindow();
                    window.ShowDialog();
                    // 刷新数据库
                    Cargos = new CargoProvider().Select();
                });
            }
        }

    }
}
