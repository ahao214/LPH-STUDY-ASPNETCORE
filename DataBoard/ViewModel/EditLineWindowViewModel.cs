﻿using DataBoard.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.ViewModel
{
    /// <summary>
    /// 编辑生产线
    /// </summary>
    public class EditLineWindowViewModel:ViewModelBase
    {
        private Line line;

        public Line Line
        {
            get { return line; }
            set { line = value; RaisePropertyChanged(); }


        }

    }
}
