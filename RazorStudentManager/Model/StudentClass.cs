using System.ComponentModel.DataAnnotations;

namespace RazorStudentManager.Model
{
    /// <summary>
    /// 班级表实体类
    /// </summary>
    public class StudentClass
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "班级名称")]
        public string ClassName { get; set; }


    }

}
