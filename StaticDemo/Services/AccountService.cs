using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticDemo.Model;


namespace StaticDemo.Services
{
    internal class AccountService : IAccountService
    {
        public void Reg(User user)
        {
            Console.WriteLine("Rick注册成功");
        }
    }
}
