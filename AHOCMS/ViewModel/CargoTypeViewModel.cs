using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using AHOCMS.Models;
using Models;

namespace AHOCMS.ViewModel
{
    public class CargoTypeViewModel:ViewModelBase
    {
        private List<CargoType> cargoTypes = new List<CargoType>();

        /// <summary>
        /// 所有物资类型
        /// </summary>
        public List<CargoType> CargoTypes
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

        public CargoTypeViewModel()
        {
            cargoTypes = new CargoTypeProvider().Select();
        }
    }
}
