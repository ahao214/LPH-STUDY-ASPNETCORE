using DataBoard.Model;
using DataBoard.Model.Provider;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.ViewModel
{
    public class SubLineViewModel:ViewModelBase
    {
        private SubLineProvider _subLineProvider = new SubLineProvider();

        /// <summary>
        /// 构造函数
        /// </summary>
        public SubLineViewModel()
        {
            subLines = _subLineProvider.Select();
        }

        private List<SubLine> subLines;
        public List<SubLine> SubLines
        {
            get { return subLines; }
            set { subLines = value; RaisePropertyChanged(); }
        }


        /// <summary>
        /// 添加子线
        /// </summary>
        public RelayCommand OpenAddSubLineWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    dialog.ShowMessage("AddLineWindow", "提示");
                    SubLines = _subLineProvider.Select();
                });
            }
        }


        /// <summary>
        /// 修改子线
        /// </summary>
        public RelayCommand<Line> OpenEditSubLineWindowCommand
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
                    SubLines = _subLineProvider.Select();
                });
            }
        }

        /// <summary>
        /// 删除子线
        /// </summary>
        public RelayCommand<SubLine> DeleteSubLineWindowCommand
        {
            get
            {
                return new RelayCommand<SubLine>((subLine) =>
                {
                    if (subLine == null) return;
                    var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                    var task = dialog.ShowMessage("确定要删除吗?", "提示", "", () =>
                    {
                        var count = _subLineProvider.Delete(subLine);
                        if (count > 0)
                        {
                            dialog.ShowMessageBox("删除成功", "提示");
                            
                            SubLines = _subLineProvider.Select();
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
