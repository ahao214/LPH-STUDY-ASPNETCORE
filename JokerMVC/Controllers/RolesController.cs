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
        private readonly ApplicationDbContext db;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public RolesController(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
