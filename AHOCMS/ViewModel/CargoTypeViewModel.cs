using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using AHOCMS.Models;

namespace AHOCMS.ViewModel
{
    public class CargoTypeViewModel:ViewModelBase
    {
        private ObservableCollection<CargoType> cargoTypes = new ObservableCollection<CargoType>();

        /// <summary>
        /// 所有物资类型
        /// </summary>
        public ObservableCollection<CargoType> CargoTypes
        {
            get
            {
                return cargoTypes;
            }
            set
            {
                cargoTypes = value;
                RaisePropertyChanged();
            }
        }
    }
}
