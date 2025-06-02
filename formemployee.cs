using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formemployee
{
    public partial class formemployee : Form
    {
        public formemployee()
        {
            InitializeComponent();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void formemployee_Load(object sender, EventArgs e)
        {
            uC_Sanpham1.Visible = false;
            uC_Nhacungcap1.Visible = false;
            uC_Banhang1.Visible = false;
            uC_Hoadon1.Visible = false;
            uC_Thongke1.Visible = false;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            uC_Sanpham1.Visible = true;
            uC_Nhacungcap1.Visible = false;
            uC_Banhang1.Visible = false;
            uC_Hoadon1.Visible = false;
            uC_Thongke1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            uC_Nhacungcap1.Visible = true;
            uC_Sanpham1.Visible = false;
            uC_Banhang1.Visible = false;
            uC_Hoadon1.Visible = false;
            uC_Thongke1.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            uC_Banhang1.Visible = true;
            uC_Sanpham1.Visible = false;
            uC_Nhacungcap1.Visible = false;
            uC_Hoadon1.Visible = false;
            uC_Thongke1.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            uC_Hoadon1.Visible = true;
            uC_Sanpham1.Visible=false;
            uC_Nhacungcap1.Visible=false;
            uC_Banhang1.Visible=false;
            uC_Thongke1.Visible=false;
        }

        private void uC_Thongke1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_Thongke1.Visible = true;
            uC_Sanpham1.Visible = false;
            uC_Nhacungcap1.Visible = false;
            uC_Banhang1.Visible = false;
            uC_Hoadon1.Visible = false;

        }
    }
}
