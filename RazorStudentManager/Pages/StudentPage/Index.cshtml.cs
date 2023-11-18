using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorStudentManager.AppData;
using RazorStudentManager.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;



namespace RazorStudentManager.Pages.StudentPage
{
    public class IndexModel : PageModel
    {

        private readonly AppDbContext _db;
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Student> Students { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }
        public async void OnGet()
        {
            var query = _db.Students.AsNoTracking();    // AsNoTracking方法不跟踪
            if (!string.IsNullOrEmpty(Search))
            {
                query = query.Where(q => q.Name.Contains(Search));
            }
            Students = await query.ToListAsync();
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var student = await _db.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            _db.Students.Remove(student);   //把student状态设置删除
            await _db.SaveChangesAsync();

            return RedirectToPage();

        }

    }
}
