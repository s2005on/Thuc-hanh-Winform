using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4Tuan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(txtSo1.Text) + int.Parse(txtSo2.Text);    
            txtKQ.Text = a.ToString();
        }

        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            int a;  
            a = int.Parse(txtSo1.Text) - int.Parse(txtSo2.Text);
            txtKQ.Text = a.ToString();

        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            int a;  
            a = int.Parse(txtSo1.Text) * int.Parse(txtSo2.Text);    
            txtKQ.Text = a.ToString();

        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            int a;
                
            a = int.Parse(txtSo1.Text) / int.Parse(txtSo2.Text);
            txtKQ.Text = a.ToString();
        }
    }
}
