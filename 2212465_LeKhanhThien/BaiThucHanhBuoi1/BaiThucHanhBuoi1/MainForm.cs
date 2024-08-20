using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;
            MessageBox.Show($"Xin Chao Ban {tenDaNhap}. Rat vui duoc gap ban", "Thong diep chao muong");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
           
    }
}
