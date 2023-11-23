﻿using AHOCMS.Models;
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
    public class CargoViewModel : ViewModelBase
    {
        public CargoViewModel()
        {
            Cargos = new CargoProvider().Select();
            CargoTypes = new CargoTypeProvider().Select();
            UnitTypes = new UnitTypeProvider().Select();
        }

        private List<Cargo> cargos = new List<Cargo>();

        /// <summary>
        /// 所有物资
        /// </summary>
        public List<Cargo> Cargos
        {
            get
            {
                return cargos;
            }
            set
            {
                cargos = value; RaisePropertyChanged();
            }
        }


        /// <summary>
        /// 所有的物资列表
        /// </summary>
        private List<CargoType> cargoTypes = new List<CargoType>();
        public List<CargoType> CargoTypes
        {
            get { return cargoTypes; }
            set { cargoTypes = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 所有的单位信息列表
        /// </summary>
        private List<UnitType> unitTypes = new List<UnitType>();
        public List<UnitType> UnitTypes
        {
            get { return unitTypes; }
            set { unitTypes = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 打开物资添加页面
        /// </summary>
        public RelayCommand OpenAddCargoWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var window = new AddCargoWindow();
                    window.ShowDialog();
                    // 刷新数据库
                    Cargos = new CargoProvider().Select();
                });
            }
        }


        #region 删除物资
        /// <summary>
        /// 删除物资
        /// </summary>
        public RelayCommand<object> DeleteCargoCommand
        {
            get
            {
                return new RelayCommand<object>((arg) =>
                {
                    if (!(arg is Cargo model))
                        return;
                    var count = new CargoProvider().Delete(model);
                    if (count > 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    // 刷新数据库
                    Cargos = new CargoProvider().Select();
                });
            }
        }
        #endregion


        #region 编辑物资信息

        /// <summary>
        /// 编辑物资信息
        /// </summary>
        public RelayCommand<object> EditCargoCommand
        {
            get
            {
                return new RelayCommand<object>((arg) =>
                {
                    if (!(arg is Cargo model))
                        return;

                    model.TypeId = CargoTypes.FirstOrDefault(t => t.Name == model.TypeName).Id;
                    model.UnitId = UnitTypes.First(t => t.Name == model.UnitName).Id;

                    var count = new CargoProvider().Update(model);
                    if (count > 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    // 刷新数据库
                    Cargos = new CargoProvider().Select();
                });
            }
        }


        #endregion

    }
}
