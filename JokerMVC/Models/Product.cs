
namespace JokerMVC.Models
{
    /// <summary>
    /// 商品实体类
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public short? Stock { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile? FormFile { get; set; }

    }
}
