using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudentManager.Model;
using RazorStudentManager.AppData;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace RazorStudentManager.Pages.StudentPage
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _db;
        public EditModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]  //��ǰ�˵Ĵ����
        public Student student { get; set; }
        // �༶��Ϣ�б�
        public SelectList ClassList { get; set; }
        public async void OnGet(int id)
        {
            // ���ذ༶�б�
            var items = await _db.Students.ToListAsync();
            ClassList = new SelectList(items, "Id", "ClassName");
            // ����ѧ����Ϣ
            student = await _db.Students.FindAsync(id);
        }

        /// <summary>
        /// �༭���ݷ���
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
                studentObj.StudentClassId = student.StudentClassId;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }
}