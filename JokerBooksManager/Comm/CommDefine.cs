﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using JokerBooksManagerComm.Comm;
using JokerBooksManagerBLL.BookBLL;
using Sunny.UI;


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
                cbo.DisplayMember = "PublishName";
                cbo.ValueMember = "PublishId";
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
                cbo.DisplayMember = "PublishName";
                cbo.ValueMember = "PublishId";
            }
            catch (System.Exception err)
            {
                CommMsgBox.MsgBoxCaveat(err.Message);
            }

        }

        #endregion

    }
}