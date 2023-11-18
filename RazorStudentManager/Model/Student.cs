﻿using System.ComponentModel.DataAnnotations;

namespace RazorStudentManager.Model
{
    /// <summary>
    /// 学生信息实体类
    /// </summary>
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "姓名")]
        [MaxLength(40)]
        public string Name { get; set; }
        [Display(Name = "年龄")]
        public int Age { get; set; }
        [Display(Name = "电话")]
        public string Phone { get; set; }
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Display(Name = "性别")]
        public Gender Gender { get; set; }
    }
}
