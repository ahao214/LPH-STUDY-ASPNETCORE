using AHOCMS.Models;
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
    /// <summary>
    /// 添加物资
    /// </summary>
    public class AddCargoViewModel : ViewModelBase
    {
        public AddCargoViewModel()
        {
            CargoTypes = new CargoTypeProvider().Select();
         }

        private Cargo cargo = new Cargo();
        /// <summary>
        /// 当前物资
        /// </summary>
        public Cargo Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                cargo = value; RaisePropertyChanged();
            }
        }

        /// <summary>
        /// 所有的物资类型列表
        /// </summary>
        private List<CargoType> cargoTypes = new List<CargoType>();
        public List<CargoType> CargoTypes
        {
            get { return cargoTypes; }
            set { cargoTypes = value; RaisePropertyChanged(); }
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

        /// <summary>
        /// 添加新的物资类型
        /// </summary>
        public RelayCommand<Window> InsertCargoTypeCommand
        {
            get
            {
                return new RelayCommand<Window>((arg) =>
                {
                    if (string.IsNullOrEmpty(cargo.Name))
                        return;
                    cargo.InsertDate = DateTime.Now;
                    
                    var count = new CargoProvider().Insert(cargo);
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

    }
}
