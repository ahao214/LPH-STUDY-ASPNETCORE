using StaticDemo.Model;
using StaticDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    //装饰器类
    public class AccountDecorator : IAccountService
    {
        private readonly IAccountService _accountService;

        public AccountDecorator(IAccountService accountService)
        {
            _accountService = accountService;
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
