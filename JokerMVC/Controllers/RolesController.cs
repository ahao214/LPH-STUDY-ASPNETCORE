using JokerMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace JokerMVC.Controllers
{
    /// <summary>
    /// 角色控制器
    /// </summary>
    public class RolesController : Controller
    {
        private readonly ApplicationDbContext db;
        public RolesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
