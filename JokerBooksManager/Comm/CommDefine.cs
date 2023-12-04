using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerBLL.BookBLL;
using Sunny.UI;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;


namespace JokerBooksManager.Comm
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


        #region 读者编码加一 

        /// <summary>
        /// 读者编码加一
        /// </summary>
        /// <param name="readerNumber"></param>
        /// <returns>返回加一后的读者编码</returns>
        public static string NumberPlusOne(string readerNumber)
        {
            int len = readerNumber.Length;
            readerNumber = readerNumber.Substring(2, len - 2);
            int iNumber = readerNumber.ChangeInt() + 1;
            return FillIn(iNumber.ToString());
        }

        #endregion


        #region 构造11位读者编码
        /// <summary>
        /// 构造11位读者编码
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        private static string FillIn(string dataSource)
        {
            // 首先得到字符串长度
            int len = dataSource.Length;
            // 判断字符串是否已经是11位了
            if (len == CommConst.ReaderNumberLen) return dataSource;
            // 如果不是11位，进行补零操作(在左边)
            int end = CommConst.ReaderNumberLen - len;
            for (int i = 0; i <= end; i++)
            {
                dataSource = "0" + dataSource;
            }
            return CommConst.PrefixReaderNumber + dataSource;
        }
        #endregion

        #region 绑定出版社


        public static void PublishDataBind(UIComboBox cbo)
        {
            try
            {
                PublishHouseBLL bll = new PublishHouseBLL();
                cbo.DataSource = bll.GetPublishHouses();
                cbo.DisplayMember = "PublishName";
                cbo.ValueMember = "PublishId";
                if (cbo.Items.Count > 0)
                    cbo.SelectedIndex = 0;
            }
            catch (System.Exception err)
            {
                CommMsgBox.MsgBoxCaveat(err.Message);
            }

        }

        #endregion


        #region 绑定图书类别

        public static void BookTypeDataBind(UIComboBox cbo)
        {
            try
            {
                BookTypeBLL bll = new BookTypeBLL();
                cbo.DataSource = bll.GetBookTypes();
                cbo.DisplayMember = "BookTypeName";
                cbo.ValueMember = "BookTypeId";
                if (cbo.Items.Count > 0)
                    cbo.SelectedIndex = 0;
            }
            catch (System.Exception err)
            {
                CommMsgBox.MsgBoxCaveat(err.Message);
            }

        }

        #endregion

        #region 绑定图书作者

        public static void AuthorDataBind(UIComboBox cbo)
        {
            try
            {
                AuthorBLL bll = new AuthorBLL();
                cbo.DataSource = bll.GetAuthors();
                cbo.DisplayMember = "AuthorName";
                cbo.ValueMember = "AuthorId";
                if (cbo.Items.Count > 0)
                    cbo.SelectedIndex = 0;
            }
            catch (System.Exception err)
            {
                CommMsgBox.MsgBoxCaveat(err.Message);
            }

        }

        #endregion

        #region 验证纯数字
        /// <summary>
        /// 验证纯数字
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsDigital(string input)
        {
            return Regex.IsMatch(input, "^[1-9]([0-9])*$");
        }

        #endregion


        #region 验证小数点后面有两位数字
        /// <summary>
        /// 验证小数点后面有两位数字
        /// </summary>
        /// <param name="input">输入的值</param>
        /// <returns>正确返回True 否则返回False</returns>
        public static bool IsDecimal(string input)
        {
            return Regex.IsMatch(input, @"^(\d+)$|^(\d+[.]\d{2})$");

        }

        #endregion

        #region  转换图片

        /// <summary>
        /// 转换图片
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static byte[] ImageToByte(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, ImageFormat.Bmp);
            byte[] bytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(bytes, 0, bytes.Length);
            stream.Close();
            return bytes;

        }

        #endregion

    }
}
