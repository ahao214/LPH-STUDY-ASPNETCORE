using JokerBooksManagerDAL.BookDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerBLL.BookBLL
{
    /// <summary>
    /// 图书借阅
    /// </summary>
    public class BorrowBookBLL
    {
        #region 获取所有借阅记录

        /// <summary>
        /// 获取所有借阅记录
        /// </summary>
        /// <returns></returns>
        public List<BorrowBook> GetBorrowBooks()
        {
            try
            {
                return BorrowBookDAL.GetBorrowBooks();
            }
            catch (Exception err)
            {
                throw err;
            }
        }


    #endregion

}
}
