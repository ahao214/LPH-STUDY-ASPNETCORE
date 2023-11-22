using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace JokerBooksManagerComm.Comm
{
    public class CommDefine
    {

        #region 获取MD5哈希值

        /// <summary>
        /// 获取MD5哈希值
        /// </summary>
        /// <param name="sVal">传入的字符</param>
        /// <returns>返回加密后的字符串</returns>
        public static string GetMD5Hash(string sVal)
        {
            MD5 md5 = MD5.Create();
            byte[] bs = md5.ComputeHash(Encoding.Default.GetBytes(sVal));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bs.Length; i++)
            {
                sb.Append(bs[i].ToString("x2"));
            }
            return sb.ToString();
        }

        #endregion

        #region 字符替换

        /// <summary>
        /// 字符替换
        /// </summary>
        /// <param name="val">字符串</param>
        /// <returns>返回替换后的字符</returns>
        public static string RepString(string val)
        {
            if (val.Length == 0 || string.IsNullOrEmpty(val))
            {
                return "";
            }
            val = val.Replace("/", "-");
            return val;
        }

        #endregion

    }
}
