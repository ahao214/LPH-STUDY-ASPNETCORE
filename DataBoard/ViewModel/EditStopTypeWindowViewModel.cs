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
    public class EditStopTypeWindowViewModel:ViewModelBase
    {
        private Line line;

        public Line Line
        {
            get { return line; }
            set { line = value; RaisePropertyChanged(); }


        }




        /// <summary>
        /// 修改生产线信息
        /// </summary>
        public RelayCommand<Window> EditLineCommand
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
                    var count = lineProvider.Update(this.line);
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
