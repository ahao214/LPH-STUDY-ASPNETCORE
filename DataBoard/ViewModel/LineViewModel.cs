﻿using DataBoard.Model;
using DataBoard.Model.Provider;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.ViewModel
{
    /// <summary>
    /// 生产线
    /// </summary>
    public class LineViewModel : ViewModelBase
    {
        private LineProvider _lineProvider = new LineProvider();

        /// <summary>
        /// 构造函数
        /// </summary>
        public LineViewModel()
        {
            lines = _lineProvider.Select();
        }

        private List<Line> lines;
        public List<Line> Lines
        {
            get { return lines; }
            set { lines = value; }
        }



    }
}