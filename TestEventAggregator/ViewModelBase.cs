using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq.Expressions;



namespace TestEventAggregator
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public void RaisePropertyChanged<T>(Expression<Func<T>> expression)
        {
            MemberExpression memberExpression =(MemberExpression) expression.Body;
            string propName = memberExpression .Member.Name;
            RaisePropertyChanged(propName);
        }
    }
}
