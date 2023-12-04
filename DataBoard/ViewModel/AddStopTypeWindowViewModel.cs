using CommonServiceLocator;
using DataBoard.Model;
using DataBoard.Model.Provider;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Windows;

namespace DataBoard.ViewModel
{
    public class AddStopTypeWindowViewModel : ViewModelBase
    {
        private StopType stopType = new StopType();

        public StopType StopType
        {
            get { return stopType; }
            set { stopType = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 添加停机类型
        /// </summary>
        public RelayCommand<Window> AddStopTypeCommand
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {
                    if (string.IsNullOrEmpty(stopType.Name))
                        return;
                    if (stopType.Name.Length > 32)
                        return;

                    var appData = ServiceLocator.Current.GetInstance<AppData>();
                    this.stopType.UserInfoId = appData.CurrentUser.Id;
                    this.stopType.InsertDate = DateTime.Now;
                    StopTypeProvider provider = new StopTypeProvider();
                    var count = provider.Insert(this.stopType);
                    if (count > 0)
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessageBox("添加成功", "提示");
                        window.Close();
                        this.StopType = new StopType();
                    }
                    else
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessageBox("添加失败", "提示");
                    }
                });
            }
        }

    }
}
