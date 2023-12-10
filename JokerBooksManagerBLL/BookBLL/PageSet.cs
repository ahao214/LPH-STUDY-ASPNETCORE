using System.Collections.Generic;


namespace JokerBooksManagerBLL.BookBLL
{
    /// <summary>
    /// 业务逻辑层分页类
    /// </summary>
    public class PageSet<T> where T : class
    {
        /// <summary>
        /// 一次性从数据库取出所有的记录
        /// </summary>
        private List<T> list;
        /// <summary>
        /// 总记录数
        /// </summary>
        private int _totalCount;

        public int TotalCount
        {
            get { return _totalCount; }
            set { _totalCount = value; }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        private int _pageCount;
        public int PageCount
        {
            get { return _pageCount; }

        }

        /// <summary>
        /// 每页记录数
        /// </summary>
        private int _pageSize;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }

        /// <summary>
        /// 当前页
        /// </summary>
        private int _nowPage;
        public int nowPage
        {
            get { return _nowPage; }
            set { _nowPage = value; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public PageSet(List<T> _bookInfos, int _pageSize)
        {
            list = _bookInfos;                 // 传递所有Model记录
            this._pageSize = _pageSize;             // 每页显示条数
            TotalCount = list.Count;           // 得到总记录数
            _pageCount = TotalCount / _pageSize;    // 总页数
            if (TotalCount % _pageSize != 0)
            {
                _pageCount++;
            }
            _nowPage = 1;
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public List<T> FirstPage()
        {
            _nowPage = 1;   // 首页就是第一页
            return GetListInfos();
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <returns></returns>
        public List<T> NextPage()
        {
            if (++_nowPage > _pageCount)
                _nowPage = _pageCount;
            return GetListInfos();
        }


        #region 上一页
        public List<T> PrevPage()
        {
            if (--_nowPage < 1)
                _nowPage = 1;
            return GetListInfos();
        }

        #endregion

        #region 尾页

        public List<T> EndPage()
        {
            _nowPage = _pageCount;
            return GetListInfos();
        }

        #endregion


        private List<T> GetListInfos()
        {
            List<T> subList = new List<T>();

            if (_pageCount == 0)
                return subList;

            int iStart = (_nowPage - 1) * _pageSize; // 循环的起始下标
            int iEnd = _nowPage * _pageSize - 1;    // 循环的终止下标

            if (_nowPage >= _pageCount)
            {
                iEnd = _totalCount - 1;
            }
            for (int i = iStart; i <= iEnd; i++)
            {
                subList.Add(list[i]);
            }
            return subList;
        }


    }


}
