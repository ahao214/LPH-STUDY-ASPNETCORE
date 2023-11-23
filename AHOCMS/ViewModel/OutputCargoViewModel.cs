using AHOCMS.Models;
using GalaSoft.MvvmLight;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOCMS.ViewModel
{
    /// <summary>
    /// 出库管理
    /// </summary>
    public class OutputCargoViewModel: ViewModelBase
    {
        public OutputCargoViewModel()
        {
            Cargos = new CargoProvider().Select();
        }
        public AppData AppData { get; set; } = new AppData();

        private Record record = new Record();

        /// <summary>
        /// 出库流水单
        /// </summary>
        public Record Record
        {
            get
            {
                return record;
            }
            set
            {
                record = value; RaisePropertyChanged();
            }
        }


        private List<Cargo> cargos = new List<Cargo>();

        /// <summary>
        /// 所有物资
        /// </summary>
        public List<Cargo> Cargos
        {
            get
            {
                return cargos;
            }
            set
            {
                cargos = value; RaisePropertyChanged();
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

        /// <summary>
        /// 添加新的物资类型
        /// </summary>
        public RelayCommand<Window> InsertCargoTypeCommand
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
