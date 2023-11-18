using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudentManager.Model;
using RazorStudentManager.AppData;
using System.Threading.Tasks;

namespace RazorStudentManager.Pages.StudentPage
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;
        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]  //和前端的代码绑定
        public Student student { get; set; }

        public void OnGet() // 获取数据
        {


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
