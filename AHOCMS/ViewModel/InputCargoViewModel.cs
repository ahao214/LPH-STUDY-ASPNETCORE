﻿using AHOCMS.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOCMS.ViewModel
{
    /// <summary>
    /// 入库管理
    /// </summary>
    public class InputCargoViewModel: ViewModelBase
    {
        public AppData AppData { get; set; } = new AppData();

        private Record record = new Record();

        /// <summary>
        /// 入库流水单
        /// </summary>
        public Record Record
        {
            get
            {
                return record;
            }
            set
            {
                record = value; RaisePropertyChanged();
            }
        }

    }
}
