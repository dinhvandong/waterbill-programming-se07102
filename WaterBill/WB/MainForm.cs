using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBill
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

           /* this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;*/

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            float num1 = float.Parse(txt_num1.Text.ToString());

            float num2 = float.Parse(txt_num2.Text.ToString());

            float sum = num1 + num2;

            txt_result.Text = sum.ToString();

        }

        private void btnMul_Click(object sender, EventArgs e)
        {

            float num1 = float.Parse(txt_num1.Text.ToString());

            float num2 = float.Parse(txt_num2.Text.ToString());

            float sum = num1 * num2;

            txt_result.Text = sum.ToString();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txt_num1.Text.ToString());

            float num2 = float.Parse(txt_num2.Text.ToString());

            float sum = num1 - num2;

            txt_result.Text = sum.ToString();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txt_num1.Text.ToString());

            float num2 = float.Parse(txt_num2.Text.ToString());

            float sum = num1 / num2;

            txt_result.Text = sum.ToString();
        }
    }
}
