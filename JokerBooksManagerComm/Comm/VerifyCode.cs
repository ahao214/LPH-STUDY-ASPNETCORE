using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        /// <summary>
        /// 验证码字体字段
        /// </summary>
        private string _fontName = FtName;
        public string FontName
        {
            set
            {
                _fontName = string.IsNullOrEmpty(value) ? _fontName : value;
            }
        }

        /// <summary>
        /// 验证码字体大小字段
        /// </summary>
        private int _fontSize = FtSize;
        public int FontSize
        {
            set
            {
                _fontSize = value <= 0 ? _fontSize : value;
            }
        }

        #endregion


        #region 创建验证码

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
            Font font = new Font(_fontName, _fontSize, FontStyle.Regular);
            Brush brush = new SolidBrush(Color.Green);
            gra.Clear(ColorTranslator.FromHtml("#eff8e8"));
            SizeF charSize;
            PointF pointF = new PointF(0, 2);
            float sepDistance = 3.5F;
            char[] vs = sCode.ToCharArray();
            for (int i = 0; i < vs.Length; i++)
            {
                string sChar = vs[i].ToString();
                charSize = gra.MeasureString(sChar, font);
                gra.DrawString(sChar, font, brush, pointF);
                pointF.X += charSize.Width + sepDistance;
            }
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Jpeg);

            return bitmap;
        }

        #endregion

    }
}
