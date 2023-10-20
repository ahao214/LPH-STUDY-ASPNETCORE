using static System.Console;
using StaticDemo.Model;
using StaticDemo.Services;
using StaticDemo;

{

    IAccountService accountService = new AccountService();
    var account = new AccountDecorator(accountService);

    var user = new User { Id = 1, Name = "Tom", Password = "123456" };
    account.Reg(user);

    Console.WriteLine("-----");
    accountService.Reg(user);
}


{
    Console.WriteLine("-----");
    var account = new ProxyAccount();
    var user = new User { Id = 2, Name = "Jack", Password = "1111" };
    account.Reg(user);

}


