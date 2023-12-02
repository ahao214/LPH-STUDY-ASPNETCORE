using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenu
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Department> departments = new ObservableCollection<Department>();

        public ObservableCollection<Department> Departments
        {
            get
            {
                return departments;
            }
            set
            {
                departments = value;
                RaisePropertyChanged(() => Departments);
            }
        }

        public MainWindowViewModel()
        {
            Departments = new ObservableCollection<Department>()
            {
                new Department()
                {
                    Name ="部门1",
                    ImgPath="Images/OS3.pgn"
                },
                new Department()
                {
                    Name ="部门2",
                    ImgPath="Images/OS3.pgn"
                },
                new Department()
                {
                    Name ="部门3",
                    ImgPath="Images/OS3.pgn"
                },
                new Department()
                {
                    Name ="部门4",
                    ImgPath="Images/OS3.pgn"
                },
                new Department()
                {
                    Name ="部门5",
                    ImgPath="Images/OS3.pgn"
                },
                new Department()
                {
                    Name ="部门6",
                    ImgPath="Images/OS3.pgn"
                },
                new Department()
                {
                    Name ="部门7",
                    ImgPath="Images/OS3.pgn"
                },
            };
        }


    }
}
