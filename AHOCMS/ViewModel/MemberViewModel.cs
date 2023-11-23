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
    public class MemberViewModel: ViewModelBase
    {
        public AppData AppData { get; set; } = AppData.Instance;

        public MemberViewModel()
        {
            Members = new MemberProvider().Select();
        }

        private List<Member> members = new List<Member>();

        /// <summary>
        /// 所有人员
        /// </summary>
        public List<Member> Members
        {
            get
            {
                return members;
            }
            set
            {
                members = value; RaisePropertyChanged();
            }
        }



        /// <summary>
        /// 打开人员添加页面
        /// </summary>
        public RelayCommand OpenAddMemberWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var window = new AddMemberWindow();
                    window.ShowDialog();
                    // 刷新数据库
                    Members = new MemberProvider().Select();
                });
            }
        }


        #region 删除人员
        /// <summary>
        /// 删除人员
        /// </summary>
        public RelayCommand<object> DeleteMemberCommand
        {
            get
            {
                return new RelayCommand<object>((arg) =>
                {
                    if (!(arg is Member model))
                        return;
                    var count = new MemberProvider().Delete(model);
                    if (count > 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    // 刷新数据库
                    Members = new MemberProvider().Select();
                });
            }
        }
        #endregion


        #region 编辑人员信息

        /// <summary>
        /// 编辑人员信息
        /// </summary>
        public RelayCommand<object> EditMemberCommand
        {
            get
            {
                return new RelayCommand<object>((arg) =>
                {
                    if (!(arg is Member model))
                        return;

                    var count = new MemberProvider().Update(model);
                    if (count > 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    // 刷新数据库
                    Members = new MemberProvider().Select();
                });
            }
        }


        #endregion

    }
}
