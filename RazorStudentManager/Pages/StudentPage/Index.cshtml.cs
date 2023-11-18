using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorStudentManager.AppData;
using RazorStudentManager.Model;
using System.Collections.Generic;

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



    }
}
