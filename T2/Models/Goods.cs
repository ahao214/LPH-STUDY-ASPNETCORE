namespace T2.Models
{
    public class Goods
    {

        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public int GoodsPrice { get; set; }

        public Goods()
        { }


        public Goods(int goodsId, string goodsName, int goodsPrice)
        {
            GoodsId = goodsId;
            GoodsName = goodsName;
            GoodsPrice = goodsPrice;
        }
    }
}
