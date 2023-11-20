using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ReturnResult(char val)
        {
            string result = string.Empty;
            switch (val)
            {
                case 'A':
                    result = "90-100";
                    break;
                case 'B':
                    result = "80-89";
                    break;
                case 'C':
                    result = "70-79";
                    break;
                case 'D':
                    result = "60-69";
                    break;
                default:
                    result = "不及格";
                    break;
            }
            return result;
        }

    }
}
