using CommonServiceLocator;
using GalaSoft.MvvmLight;

namespace DataBoard.ViewModel
{  
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            appData = ServiceLocator.Current.GetInstance<AppData>();
        }

        private AppData appData;
        public AppData AppData
        {
            get { return appData; }
            set { appData = value; }
        }
    }
}