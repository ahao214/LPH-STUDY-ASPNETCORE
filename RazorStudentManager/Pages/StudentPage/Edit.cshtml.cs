using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudentManager.Model;
using RazorStudentManager.AppData;
using System.Threading.Tasks;

namespace RazorStudentManager.Pages.StudentPage
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _db;
        public EditModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]  //和前端的代码绑定
        public Student student { get; set; }
        public async void OnGet(int id)
        {
            student = await _db.Students.FindAsync(id);
        }

        /// <summary>
        /// 编辑数据方法
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPost()
        {
            if(ModelState .IsValid )
            {
                var studentObj = await _db.Students.FindAsync(student.Id);
                studentObj.Name = student.Name;
                studentObj.Age = student.Age;
                studentObj.Phone = student.Phone;
                studentObj.Address = student.Address;
                studentObj.Gender = student.Gender;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }
}
