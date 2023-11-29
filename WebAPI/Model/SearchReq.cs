using System.ComponentModel;

namespace WebAPI.Model
{
    public class SearchReq
    {
        [DefaultValue("zhangsan")]
        public string Name { get; set; }
        [DefaultValue(1)]
        public int PageIndex { get; set; }
        [DefaultValue(10)]
        public int PageSize { get; set; }

    }
}
