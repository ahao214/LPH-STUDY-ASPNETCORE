using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingAndCheck
{
    public class Employee:INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                // 在属性值变更后，激发 PropertyChanged 事件
                // 参数1：事件来源
                // 参数2：属性变更事件参数
                if(this.PropertyChanged != null)    // 无订阅判断，避免激发空事件产生异常
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
