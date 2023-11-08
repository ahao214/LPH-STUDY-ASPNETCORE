using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Server.Data
{
    public class Todo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        public DateTime? PlanTime { get; set; }

    }
}
