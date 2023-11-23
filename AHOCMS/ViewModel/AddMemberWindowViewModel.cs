using AHOCMS.Models;
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
    public class AddMemberWindowViewModel : ViewModelBase
    {
        public AddMemberWindowViewModel()
        {
            
        }

        public AppData AppData { get; set; } = AppData.Instance;

        private Member member = new Member();
        public Member Member
        {
            get { return member; }
            set
            {
                member = value; RaisePropertyChanged();
            }
        }

       

        /// <summary>
        /// 关闭窗体
        /// </summary>
        public RelayCommand<Window> CloseCommand
        {
            get
            {
                return new RelayCommand<Window>((arg) =>
                {
                    if (arg == null)
                        return;
                    arg.Close();
                });
            }
        }

        /// <summary>
        /// 添加新的用户
        /// </summary>
        public RelayCommand<Window> AddMemberCommand
        {
            get
            {
                return new RelayCommand<Window>((arg) =>
                {
                    if (string.IsNullOrEmpty(member.Name))
                        return;
                    if (string.IsNullOrEmpty(member.Password))
                        return;
                    
                    member.InsertDate = DateTime.Now;

                    var count = new MemberProvider().Insert(member);
                    if (count == 0)
                    {
                        MessageBox.Show("添加失败");
                    }
                    else
                    {
                        arg.Close();
                    }
                });
            }
        }

    }
}
