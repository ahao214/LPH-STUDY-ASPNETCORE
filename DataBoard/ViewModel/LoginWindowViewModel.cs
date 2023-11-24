﻿using CommonServiceLocator;
using DataBoard.Model;
using DataBoard.Views;
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
    public class LoginWindowViewModel : ViewModelBase
    {
        private AppData appData;
        /// <summary>
        /// 构造函数
        /// </summary>
        public LoginWindowViewModel()
        {
            appData = ServiceLocator.Current.GetInstance<AppData>();
        }

        public AppData AppData
        {
            get { return appData; }
            set { appData = value; }
        }


        /// <summary>
        /// 登录按钮事件
        /// </summary>
        //public ICommand CheckUserCommand
        //{
        //    get
        //    {
        //        var command = new RelayCommand(() =>
        //        {
        //            BoardDBEntities db = new BoardDBEntities();
        //            var model = db.UserInfo .ToList ().FirstOrDefault (item=>item .Name ==appData .CurrentUser .Name && 
        //            item .Password ==appData .CurrentUser .Password);
        //            if (model ==null )
        //            {
        //                return;
        //            }
        //            AppData.CurrentUser = model;
        //            MainWindow main = new MainWindow();
        //            main.Show();
        //        });
        //        return command;
        //    }
        //}


        /// <summary>
        /// 登录按钮事件
        /// </summary>
        public RelayCommand<LoginWindow> CheckUserCommand
        {
            get
            {
                var command = new RelayCommand<LoginWindow>((loginWidow) =>
                {
                    BoardDBEntities db = new BoardDBEntities();
                    var model = db.UserInfo.ToList().FirstOrDefault(item => item.Name == appData.CurrentUser.Name &&
                    item.Password == appData.CurrentUser.Password);
                    if (model == null)
                    {
                        var dialog = SimpleIoc.Default.GetInstance<IDialogService>();
                        dialog.ShowMessage("用户名或密码错误", "提示");
                        return;
                    }
                    AppData.CurrentUser = model;
                    MainWindow main = new MainWindow();
                    main.Show();
                    loginWidow.Close();
                });
                return command;
            }
        }

    }
}