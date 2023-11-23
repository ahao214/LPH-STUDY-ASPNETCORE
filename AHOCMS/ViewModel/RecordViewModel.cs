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
    public class RecordViewModel:ViewModelBase
    {
        public RecordViewModel()
        {
            Records = new RecordProvider().Select();
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

        private List <Record> records = new List<Record>(); 
        
        public List <Record> Records
        {
            get
            {
                return records;
            }
            set
            {
                records = value; RaisePropertyChanged();    
            }
        }


        /// <summary>
        /// 打开入库页面
        /// </summary>
        public RelayCommand OpenInputWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var window = new InputCargoWindow();
                    window.ShowDialog();
                    // 刷新数据库
                    Records = new RecordProvider().Select();
                });
            }
        }

        /// <summary>
        /// 打开出库页面
        /// </summary>
        public RelayCommand OpenOutputWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var window = new OutCargoWindow();
                    window.ShowDialog();
                    // 刷新数据库
                    Records = new RecordProvider().Select();
                });
            }
        }


        #region 删除入库
        /// <summary>
        /// 删除入库
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
                    Records = new RecordProvider().Select();
                });
            }
        }
        #endregion


        #region 编辑入库信息

        /// <summary>
        /// 编辑入库信息
        /// </summary>
        public RelayCommand<object> EditRecordCommand
        {
            get
            {
                return new RelayCommand<object>((arg) =>
                {
                    if (!(arg is Record model))
                        return;

                    //model.TypeId = CargoTypes.FirstOrDefault(t => t.Name == model.TypeName).Id;
                    

                    var count = new RecordProvider().Update(model);
                    if (count > 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    // 刷新数据库
                    Records = new RecordProvider().Select();
                });
            }
        }


        #endregion
    }
}
