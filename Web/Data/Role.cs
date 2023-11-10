using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Web.Data
{
    [Table("Roles")]
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [JsonIgnore]
        public User? User { get; set; }

    }
}
