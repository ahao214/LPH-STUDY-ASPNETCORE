using AHOCMS.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AHOCMS.ViewModel
{
    /// <summary>
    /// 入库管理
    /// </summary>
    public class InputCargoViewModel : ViewModelBase
    {
        public InputCargoViewModel()
        {
            Cargos = new CargoProvider().Select();
        }

        public AppData AppData { get; set; } = new AppData();

        private Record record = new Record();

        /// <summary>
        /// 入库流水单
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
        /// 添加入库数量
        /// </summary>
        public RelayCommand<Window> AddInputCommand
        {
            get
            {
                return new RelayCommand<Window>((arg) =>
                {
                    if (string.IsNullOrEmpty(record.CargoName))
                        return;
                    var cargo = this.Cargos.FirstOrDefault(item => item.Name == record.CargoName);
                    if (cargo == null) return;
                    record.CargoId = cargo.Id;

                    if (record.Number == 0)
                        return;
                    record.InsertDate = DateTime.Now;
                    record.MemberId = AppData.CurrentUser.Id;
                    record.MemberName = AppData.CurrentUser.Name;
                    record.RecordType = true;
                    var count = new RecordProvider().Insert(record);
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
