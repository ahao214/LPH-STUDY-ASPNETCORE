using DataBoard.Model;
using DataBoard.Model.Provider;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.ViewModel
{
    /// <summary>
    /// 生产线
    /// </summary>
    public class LineViewModel : ViewModelBase
    {
        private LineProvider _lineProvider = new LineProvider();

        /// <summary>
        /// 构造函数
        /// </summary>
        public LineViewModel()
        {
            lines = _lineProvider.Select();
        }

        private List<Line> lines;
        public List<Line> Lines
        {
            get { return lines; }
            set { lines = value; RaisePropertyChanged(); }
        }


        /// <summary>
        /// 打开生产线
        /// </summary>
        public RelayCommand OpenAddLineWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    dialog.ShowMessage("AddLineWindow", "提示");
                    Lines = _lineProvider.Select();
                });
            }
        }


        /// <summary>
        /// 修改生产线
        /// </summary>
        public RelayCommand<Line> OpenEditLineWindowCommand
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
                    dialog.ShowMessage("EditLineWindow", "提示");
                    Lines = _lineProvider.Select();
                });
            }
        }

        /// <summary>
        /// 删除生产线
        /// </summary>
        public RelayCommand<Line> DeleteLineWindowCommand
        {
            get
            {
                return new RelayCommand<Line>((line) =>
                {
                    if (line == null) return;
                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    var task = dialog.ShowMessage("确定要删除吗?", "提示", "", () =>
                    {
                        var count = _lineProvider.Delete(line);
                        if (count > 0)
                        {
                            dialog.ShowMessageBox("删除成功", "提示");
                            Lines = _lineProvider.Select();
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
