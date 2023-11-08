using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Server.Data
{
    public class Todo
    {
        /// <summary>
        /// 自增列
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]      
        public int Id { get; set; }
        /// <summary>
        /// 标题名称
        /// </summary>
        [Required,StringLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 任务描述
        /// </summary>
        [StringLength(255)]
        public string? Description { get; set; }
        /// <summary>
        /// 计划时间
        /// </summary>
        public DateTime? PlanTime { get; set; }

    }
}
