using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formcustomer.customer;

namespace Formcustomer
{
    public partial class CustomerForm : Form
    {
        // Assuming 'arr' is a list of some product type, define it here
        private List<Product> arr = new List<Product>();

        public CustomerForm()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            uC_Sanpham1.Visible = true;
            uC_Donhang1.Visible = false;
            uC_Danhgia1.Visible = false;
            uC_Thongtincanhan1.Visible = false;
            uC_Lichsudonhang1.Visible = false;

        }
        
        private void Formcustomer_Load(object sender, EventArgs e)
        {

            uC_Sanpham1.Visible = false;
            uC_Donhang1.Visible = false;
            uC_Danhgia1.Visible = false;
            uC_Thongtincanhan1.Visible = false;
            uC_Lichsudonhang1.Visible = false;

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            uC_Donhang1.Visible = true;
            uC_Sanpham1.Visible = false;
            uC_Danhgia1.Visible = false;
            uC_Thongtincanhan1.Visible = false;
            uC_Lichsudonhang1.Visible = false;


        }
        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void uC_Sanpham1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Sanpham1_Load_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            uC_Danhgia1.Visible = true;
            uC_Sanpham1.Visible = false;
            uC_Donhang1.Visible = false;
            uC_Thongtincanhan1.Visible = false;
            uC_Lichsudonhang1.Visible = false;

        }

        private void uC_Donhang1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Danhgia1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_Thongtincanhan1.Visible = true;
            uC_Sanpham1.Visible = false;
            uC_Donhang1.Visible = false;
            uC_Danhgia1.Visible = false;
            uC_Lichsudonhang1.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            uC_Lichsudonhang1.Visible = true;
            uC_Sanpham1.Visible = false;
            uC_Donhang1.Visible = false;
            uC_Thongtincanhan1.Visible = false;
            uC_Danhgia1.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }

    // Assuming a Product class exists, define it here if not already defined
    public class Product
    {
        public string Masanpham { get; set; }
        public string Tensanpham { get; set; }
        public string Gia { get; set; }
    }
}