using CommonServiceLocator;
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
using System.Windows;

namespace DataBoard.ViewModel
{
    public class EditSubLineWindowViewModel : ViewModelBase
    {
        
        private SubLine subLine;
        public SubLine SubLine
        {
            get { return subLine; }
            set { subLine = value; RaisePropertyChanged(); }
        }


        /// <summary>
        /// 修改子线信息
        /// </summary>
        public RelayCommand<Window> EditSubLineCommand
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {
                    if (string.IsNullOrEmpty(subLine.Name))
                        return;
                    if (subLine.Name.Length > 32)
                        return;

                    var appData = ServiceLocator.Current.GetInstance<AppData>();
                    this.subLine.UserInfoId = appData.CurrentUser.Id;
                    this.subLine.InsertDate = DateTime.Now;
                    SubLineProvider subLineProvider = new SubLineProvider();
                    var count = subLineProvider.Update(this.subLine);
                    if (count > 0)
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessageBox("修改成功", "提示");
                        window.Close();
                    }
                    else
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessageBox("修改失败", "提示");
                    }

                });
            }
        }
    }
}
