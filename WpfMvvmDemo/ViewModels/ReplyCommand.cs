using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmDemo.ViewModels
{
    /// <summary>
    /// 命令基础类
    /// </summary>
    public class ReplyCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        public Func<object, bool>? CanExecution { set; get; }
        public Action<object>? DoExecute { set; get; }



        /// <summary>
        /// 基于控件的IsEnabled属性而言
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object? parameter)
        {
            if (CanExecution != null)
            {
                return CanExecution(parameter);
            }
            return true;
        }

        public void Execute(object? parameter)
        {
            DoExecute?.Invoke(parameter);            
        }
    }
}
