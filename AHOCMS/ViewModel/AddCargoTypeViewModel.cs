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
    /// 增加类型
    /// </summary>
    public class AddCargoTypeViewModel : ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

        private CargoType cargoType = new CargoType();
        public CargoType CargoType
        {
            get { return cargoType; }
            set
            {
                cargoType = value;RaisePropertyChanged();
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
                    arg.Close();
                });
            }
        }

        /// <summary>
        /// 添加新的物资类型
        /// </summary>
        public RelayCommand <Window> InsertCargoTypeCommand
        {
            get
            {
                return new RelayCommand<Window>((arg) =>
                {
                    if (string.IsNullOrEmpty(cargoType.Name))
                        return;
                    cargoType.InsertDate = DateTime.Now;
                    cargoType.MemberId = AppData.CurrentUser.Id;
                    cargoType.MemberName = AppData.CurrentUser.Name;
                    var count = new CargoTypeProvider().Insert(cargoType);
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
