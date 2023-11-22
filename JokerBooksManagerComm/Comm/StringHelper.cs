using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerComm.Comm
{
    /// <summary>
    /// 扩展方法类
    /// </summary>
    public static class StringHelper
    {
        #region 将object转换为整型

        /// <summary>
        /// 将object转换为整型
        /// </summary>
        /// <param name="sVal">参数值</param>
        /// <returns>返回类型</returns>
        public static int ChangeInt(this object sVal)
        {
            int iRes;
            try
            {
                iRes = Convert.ToInt32(sVal);
            }
            catch (Exception)
            {
                iRes = 0;
            }
            return iRes;
        }

        #endregion

        #region 将object转换为短整型

        /// <summary>
        /// 将object转换为short
        /// </summary>
        /// <param name="sVal">参数值</param>
        /// <returns>返回短整型</returns>
        public static short ChangeShort(this object sVal)
        {
            short iRes;
            try
            {
                iRes = Convert.ToInt16(sVal);
            }
            catch (Exception)
            {
                iRes = 0;
            }
            return iRes;
        }

        #endregion

        #region 将BookCommandType转换为整型

        /// <summary>
        /// 将BookCommandType转换为整型
        /// </summary>
        /// <param name="sVal">参数值</param>
        /// <returns>返回类型</returns>
        public static int ChangeInt(this BookCommandType sVal)
        {
            int iRes;
            try
            {
                iRes = Convert.ToInt32(sVal);
            }
            catch (Exception)
            {
                iRes = 0;
            }
            return iRes;
        }

        #endregion




    }
}
