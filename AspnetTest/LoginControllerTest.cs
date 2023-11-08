using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreLifetime.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AspnetTest
{
    public class LoginControllerTest
    {
        [Fact]
        public void Test_Login()
        {
            var controller = new LoginController();

           var result = controller.Login(new() { UserName = "admin" });
            Assert.IsType<OkResult>(result);


        }


    }
}
