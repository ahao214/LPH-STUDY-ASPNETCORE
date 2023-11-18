using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorStudentManager.AppData;
using RazorStudentManager.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async void OnGet()
        {
            Students = await _db.Students.ToListAsync();
        }

        /// <summary>
        /// É¾³ý·½·¨
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var student = await _db.Students.FindAsync(id);
            if(student ==null)
            {
                return NotFound();
            }
            _db.Students.Remove(student);   //°Ñstudent×´Ì¬ÉèÖÃÉ¾³ý
            await _db.SaveChangesAsync();

            return RedirectToPage();

        }

    }
}
