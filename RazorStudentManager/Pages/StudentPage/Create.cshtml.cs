using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudentManager.Model;


namespace RazorStudentManager.Pages.StudentPage
{
    public class CreateModel : PageModel
    {
        [BindProperty]  //和前端的代码绑定
        public Student Student { get; set; }

        public void OnGet()
        {
        }
    }
}
