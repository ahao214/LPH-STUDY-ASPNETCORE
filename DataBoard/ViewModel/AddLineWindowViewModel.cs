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
    /// <summary>
    /// 添加生产线
    /// </summary>
    public class AddLineWindowViewModel : ViewModelBase
    {
        private Line line = new Line();

        public Line Line
        {
            get { return line; }
            set { line = value; RaisePropertyChanged(); }


        }


        public RelayCommand<Window> AddLineCommand
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {
                    if (string.IsNullOrEmpty(line.Name))
                        return;
                    if (line.Name.Length > 32)
                        return;

                    var appData = ServiceLocator.Current.GetInstance<AppData>();
                    this.line.UserInfoId = appData.CurrentUser.Id;
                    this.line.InsertDate = DateTime.Now;
                    LineProvider lineProvider = new LineProvider();
                    var count = lineProvider.Insert(this.line);
                    if (count > 0)
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessageBox("添加成功", "提示");
                        window.Close();
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
