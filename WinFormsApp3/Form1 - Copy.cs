using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class maytinh : Form
    {
        public maytinh()
        {
            InitializeComponent();
        }
        bool nhapso = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtso0_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "0";
            }
            else
                txtketqua.Text = "0";
            nhapso = true;
        }

        private void txtso1_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "1"; 
            } else
            txtketqua.Text = "1";
            nhapso = true;
        }

        private void txtso2_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "2";
            }
            else
                txtketqua.Text = "2";
            nhapso = true;
        }

        private void txtso3_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "3";
            }
            else
                txtketqua.Text = "3";
            nhapso = true;
        }

        private void txtso1so4_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "4";
            }
            else
                txtketqua.Text = "4";
            nhapso = true;
        }

        private void txtso5_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "5";
            }
            else
                txtketqua.Text = "5";
            nhapso = true;
        }

        private void txtso6_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "6";
            }
            else
                txtketqua.Text = "6";
            nhapso = true;
        }

        private void txtso7_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "7";
            }
            else
                txtketqua.Text = "7";
            nhapso = true;
        }

        private void txtso8_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "8";
            }
            else
                txtketqua.Text = "8";
            nhapso = true;
        }

        private void txtso9_Click(object sender, EventArgs e)
        {
            if (nhapso)
            {
                txtketqua.Text = txtketqua.Text + "9";
            }
            else
                txtketqua.Text = "9";
            nhapso = true;
        }
        double sotruoc;
        enum pheptinh { cong, tru,nhan,chia};
        pheptinh Pheptinh;
        private void nhappheptoan(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+":
                    Pheptinh = pheptinh.cong;
                    break;
                case "-":
                    Pheptinh = pheptinh.tru;
                    break;
                case "*":
                    Pheptinh = pheptinh.nhan;
                    break;
                case "/":
                    Pheptinh = pheptinh.chia;
                    break;
            }
            sotruoc = double.Parse(txtketqua.Text);
            nhapso = false;
        }
        private void tinhketqua()
        {
            double tam = double.Parse(txtketqua.Text);
            double so = 0.0;
            switch (Pheptinh)
            {
                case pheptinh.cong:
                    so = sotruoc + tam;
                    break;
                case pheptinh.tru:
                    so = sotruoc - tam;
                    break;
                case pheptinh.nhan:
                    so = sotruoc * tam;
                    break;
                case pheptinh.chia:
                    so = sotruoc / tam;
                    break;
            }
            txtketqua.Text = so.ToString();
        }

        private void daubang_Click(object sender, EventArgs e)
        {
            tinhketqua();
            nhapso =false;
        }
    }
}
