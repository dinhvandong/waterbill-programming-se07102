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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_password.KeyDown += textBox1_KeyDown;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string email = txt_email.Text;
                string password = txt_password.Text;

                if (email.Equals("admin@gmail.com")
                    && password.Equals("123456"))
                {
                    MainForm main = new MainForm();
                    main.Show();
                    // hide current window 
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;

            if (email.Equals("admin@gmail.com")
                && password.Equals("123456"))
            {
                MainForm main = new MainForm();
                main.Show();
                // hide current window 
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
        }
    }
}
