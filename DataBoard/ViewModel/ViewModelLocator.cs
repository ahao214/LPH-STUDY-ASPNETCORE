/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:DataBoard"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using DataBoard.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace DataBoard.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginWindowViewModel>();

            SimpleIoc.Default.Register<LineViewModel>();
            SimpleIoc.Default.Register<StopTypeViewModel>();
            SimpleIoc.Default.Register<SubLineViewModel>();
            SimpleIoc.Default.Register<UserInfoViewModel>();
            SimpleIoc.Default.Register<HistoryViewModel>();
            SimpleIoc.Default.Register<IndexViewModel>();


            SimpleIoc.Default.Register<AppData>();
            SimpleIoc.Default.Register<IDialogService, LoginWindow>();

            SimpleIoc.Default.Register<LineView>();
            SimpleIoc.Default.Register<StopTypeView>();
            SimpleIoc.Default.Register<SubLineView>();
            SimpleIoc.Default.Register<UserInfoView>();
            SimpleIoc.Default.Register<HistoryView>();
            SimpleIoc.Default.Register<IndexView>();
            
            
            SimpleIoc.Default.Register<AddLineWindowViewModel>();
            SimpleIoc.Default.Register<EditLineWindowViewModel>();

            SimpleIoc.Default.Register<AddSubLineWindowViewModel>();
            SimpleIoc.Default.Register<EditSubLineWindowViewModel>(); SimpleIoc.Default.Register<AddStopTypeWindowViewModel>();
            SimpleIoc.Default.Register<EditStopTypeWindowViewModel>();

        
        }

        public AddSubLineWindowViewModel AddSubLineWindow
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddSubLineWindowViewModel>();
            }
        }

        public EditSubLineWindowViewModel EditSubLineWindow
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EditSubLineWindowViewModel>();
            }
        }


        public AddStopTypeWindowViewModel AddStopTypeWindow
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddStopTypeWindowViewModel>();
            }
        }

        public EditStopTypeWindowViewModel EditStopTypeWindow
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EditStopTypeWindowViewModel>();
            }
        }
        public AddLineWindowViewModel AddLineWindow
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddLineWindowViewModel>();
            }
        }
        public EditLineWindowViewModel EditLineWindow
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EditLineWindowViewModel>();
            }
        }

        public IndexViewModel Index
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IndexViewModel>();
            }
        }

        public HistoryViewModel History
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HistoryViewModel>();
            }
        }

        public LineViewModel Line
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LineViewModel>();
            }
        }

        public StopTypeViewModel StopType
        {
            get
            {
                return ServiceLocator.Current.GetInstance<StopTypeViewModel>();
            }
        }

        public SubLineViewModel SubLine
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SubLineViewModel>();
            }
        }

        public UserInfoViewModel UserInfo
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UserInfoViewModel>();
            }
        }

        public LoginWindowViewModel LoginWindow
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginWindowViewModel>();
            }
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}