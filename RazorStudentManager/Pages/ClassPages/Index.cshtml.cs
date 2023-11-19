using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorStudentManager.AppData;
using RazorStudentManager.Model;

namespace RazorStudentManager.Pages.ClassPages
{
    public class IndexModel : PageModel
    {
        private readonly RazorStudentManager.AppData.AppDbContext _context;

        public IndexModel(RazorStudentManager.AppData.AppDbContext context)
        {
            _context = context;
        }

        public IList<StudentClass> StudentClass { get;set; }

        public async Task OnGetAsync()
        {
            StudentClass = await _context.StudentClasses.ToListAsync();
        }
    }
}
