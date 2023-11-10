using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Web.Data
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
