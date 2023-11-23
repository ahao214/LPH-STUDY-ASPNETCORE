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
using System.Windows;

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


        #region 删除物资
        /// <summary>
        /// 删除物资
        /// </summary>
        public RelayCommand<object> DeleteCargoCommand
        {
            get
            {
                return new RelayCommand<object>((arg) =>
                {
                    if (!(arg is Cargo model))
                        return;
                    var count = new CargoProvider().Delete(model);
                    if (count > 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    // 刷新数据库
                    Cargos = new CargoProvider().Select();
                });
            }
        }
        #endregion


        #region 编辑物资信息

        /// <summary>
        /// 编辑物资信息
        /// </summary>
        public RelayCommand<object> EditCargoCommand
        {
            get
            {
                return new RelayCommand<object>((arg) =>
                {
                    if (!(arg is Cargo model))
                        return;
                    var count = new CargoProvider().Update(model);
                    if (count > 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    // 刷新数据库
                    Cargos = new CargoProvider().Select();
                });
            }
        }


        #endregion

    }
}
