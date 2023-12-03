using DataBoard.Model.Provider;
using DataBoard.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace DataBoard.ViewModel
{
    public class StopTypeViewModel: ViewModelBase
    {
        private StopTypeProvider _stopTypeProvider = new StopTypeProvider();

        /// <summary>
        /// 构造函数
        /// </summary>
        public StopTypeViewModel()
        {
            stopTypes = _stopTypeProvider.Select();
        }

        private List<StopType> stopTypes;
        public List<StopType> StopTypes
        {
            get { return stopTypes; }
            set { stopTypes = value; RaisePropertyChanged(); }
        }


        /// <summary>
        /// 添加停机类型
        /// </summary>
        public RelayCommand OpenAddStopTypeWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    dialog.ShowMessage("AddStopTypeWindow", "提示");                    
                    StopTypes= _stopTypeProvider.Select();
                });
            }
        }


        /// <summary>
        /// 修改停机类型
        /// </summary>
        public RelayCommand<Line> OpenEditStopTypeWindowCommand
        {
            get
            {
                return new RelayCommand<Line>((line) =>
                {
                    var vm = SimpleIoc.Default.GetInstance<EditLineWindowViewModel>();
                    if (vm == null)
                        return;
                    vm.Line = line;
                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    dialog.ShowMessage("EditStopTypeWindow", "提示");
                    StopTypes = _stopTypeProvider.Select();
                });
            }
        }

        /// <summary>
        /// 删除停机类型
        /// </summary>
        public RelayCommand<StopType> DeleteStopTypeWindowCommand
        {
            get
            {
                return new RelayCommand<StopType>((stopType) =>
                {
                    if (stopType == null) return;
                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    var task = dialog.ShowMessage("确定要删除吗?", "提示", "", () =>
                    {
                        var count = _stopTypeProvider.Delete(stopType);
                        if (count > 0)
                        {
                            dialog.ShowMessageBox("删除成功", "提示");

                            StopTypes = _stopTypeProvider.Select();
                        }
                        else
                        {
                            dialog.ShowMessageBox("删除失败", "提示");
                        }
                    });
                    task.Start();
                });

            }
        }

    }
}
