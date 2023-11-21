using JokerMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;


namespace JokerMVC.Controllers
{
    /// <summary>
    /// 角色控制器
    /// </summary>
    public class RolesController : Controller
    {
        private string AdminRole = "Admin";
        private string UserEmail = "Admin@163.com";

        private readonly ApplicationDbContext db;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public RolesController(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            // 创建角色
            await roleManager.CreateAsync(new IdentityRole(AdminRole));
            // 创建管理员用户
            IdentityUser user = new IdentityUser { UserName = UserEmail, Email = UserEmail, EmailConfirmed = true };
            await userManager.CreateAsync(user, UserEmail);
            // 
            return View();
        }
    }
}
