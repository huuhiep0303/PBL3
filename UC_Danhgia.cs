using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formcustomer.customer
{
    public partial class UC_Danhgia : UserControl
    {
        public UC_Danhgia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Cảm ơn bạn đã đánh giá sản phẩm của chúng tôi!");
        }
    }
}
