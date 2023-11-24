using DataBoard.Model;
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
        private List<Line> lines;
        /// <summary>
        /// 构造函数
        /// </summary>
        public LineViewModel()
        {
                
        }

        public List<Line> Lines
        {
            get { return lines; }
            set { lines = value; }
        }

       

    }
}
