using System.Windows.Forms;

namespace JokerBooksManagerComm.Comm
{
    /// <summary>
    /// 泛型类（返回耽搁窗体）
    /// </summary>
    /// <typeparam name="T">泛型</typeparam>
    public class SingleForm<T> where T : Form, new()
    {
        /// <summary>
        /// 泛型静态变量
        /// </summary>
        private static T t = default;
        /// <summary>
        /// 泛型静态方法（创建窗体实例）
        /// </summary>
        /// <returns></returns>
        public static T CreateInstance()
        {
            if (t is null || t.IsDisposed)
            {
                t = new T();
            }
            else
            {
                t.Activate();
            }
            return t;
        }
    }
}
