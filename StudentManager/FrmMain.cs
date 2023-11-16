using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace StudentManager
{

    public partial class FrmMain : Form
    {
        ClassLogic classLogic = new ClassLogic();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string className = this.txtClassName.Text.Trim();
            bool result = classLogic.AddClass(className);
            if (result == true)
            {
                MessageBox.Show("添加成功!");
            }
            else
            {
                MessageBox.Show("添加失败!");
            }

        }
    }
}
