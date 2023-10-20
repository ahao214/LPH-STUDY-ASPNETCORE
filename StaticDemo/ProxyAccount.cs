using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticDemo.Model;
using StaticDemo.Services;

namespace StaticDemo
{
    //代理类
    public class ProxyAccount : IAccountService
    {
        private readonly IAccountService _accountService;

        public ProxyAccount( )
        {
            _accountService = new AccountService();
        }

        public void Reg(User user)
        {
            Before();
             _accountService.Reg(user);
            After();
        }

        private void Before()
        {
            Console.WriteLine("注册之前的逻辑");
        }

        private void After()
        {
            Console.WriteLine("注册之后的逻辑");
        }

    }
}
