using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingAndCheck
{
    public class Employee : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;


        int id;
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                // 在属性值变更后，激发 PropertyChanged 事件
                // 参数1：事件来源
                // 参数2：属性变更事件参数
                if (this.PropertyChanged != null)    // 无订阅判断，避免激发空事件产生异常
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ID"));
            }
        }

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
                if (this.PropertyChanged != null)    // 无订阅判断，避免激发空事件产生异常
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        int age;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;

                if (this.PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }

        string phoneType;
        public string PhoneType
        {
            get { return phoneType;}
            set
            {
                phoneType = value;
                if (this.PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("PhoneType"));

            }
        }

    }
}
