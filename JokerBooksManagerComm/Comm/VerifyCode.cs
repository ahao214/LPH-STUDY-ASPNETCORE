using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace JokerBooksManagerComm.Comm
{
    /// <summary>
    /// 封装验证码
    /// </summary>
    public class VerifyCode : CommConst
    {

        #region 验证码

        /// <summary>
        /// 验证码位数字段
        /// </summary>
        private int _codeCount = CodeCounts;
        /// <summary>
        /// 验证码位数属性
        /// </summary>
        public int CodeCount
        {
            set
            {
                _codeCount = value <= 0 ? _codeCount : value;
            }
        }

        /// <summary>
        /// 验证码字符字段
        /// </summary>
        private string _checkCode = string.Empty;
        public string CheckCode
        {
            get
            {
                return _checkCode;
            }
        }

        /// <summary>
        /// 位图宽度字段
        /// </summary>
        private int _bitMapWidth = BitMapW;
        /// <summary>
        /// 位图高度字段
        /// </summary>
        private int _bitMapHeight = BitMapH;
        public int BitMapWidth
        {
            set
            {
                _bitMapWidth = value <= 0 ? _bitMapWidth
                    : value;
            }
        }
        public int BitMapHeight
        {
            set
            {
                _bitMapHeight = value <= 0 ? _bitMapHeight
                    : value;
            }
        }


        #endregion



        /// <summary>
        /// 创建验证码
        /// </summary>
        /// <returns></returns>
        public Bitmap CreateVerifyCode()
        {
            // 生成验证码
            string sCode = string.Empty;
            for (int i = 0; i < _codeCount; i++)
            {
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                sCode += AllChar.Substring(rnd.Next(0, AllChar.Length), 1);
            }
            _checkCode = sCode;

            Bitmap bitmap = new Bitmap(_bitMapWidth, _bitMapHeight);
            Graphics gra = Graphics.FromImage(bitmap);
            return bitmap;
        }

    }
}
