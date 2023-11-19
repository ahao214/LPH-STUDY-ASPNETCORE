using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudentManager.Model;
using RazorStudentManager.AppData;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace RazorStudentManager.Pages.StudentPage
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;
        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        // 班级信息列表
        public SelectList ClassList { get; set; }

        [BindProperty]  //和前端的代码绑定
        public Student student { get; set; }

        public async void OnGet() // 获取数据
        {
            var items = await _db.Students.ToListAsync();
            ClassList = new SelectList(items, "Id", "ClassName");

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.AddAsync(student);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }




    }
}
