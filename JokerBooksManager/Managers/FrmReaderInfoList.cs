using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokerBooksManagerBLL.BookBLL;
using Sunny.UI;


namespace JokerBooksManager.Managers
{
    public partial class FrmReaderInfoList : UIForm
    {
        private ReaderInfoBLL bll = new ReaderInfoBLL();

        public FrmReaderInfoList()
        {
            InitializeComponent();
        }

        private void FrmReaderInfoList_Load(object sender, EventArgs e)
        {
            DgvReaderInfoList.DataSource = new List<string>();
        }
    }
}
