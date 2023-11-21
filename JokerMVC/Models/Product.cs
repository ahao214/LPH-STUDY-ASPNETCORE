
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JokerMVC.Models
{
    /// <summary>
    /// 商品实体类
    /// </summary>
    public class Product
    {
        [Display(Name = "商品ID")]
        public int Id { get; set; }
        [Display(Name = "商品名称")]
        public string Name { get; set; }
        [Display(Name = "商品价格")]
        public double Price { get; set; }
        [Display(Name = "商品库存")]
        public short? Stock { get; set; }
        [Display(Name = "商品图片")]
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }

    }
}
