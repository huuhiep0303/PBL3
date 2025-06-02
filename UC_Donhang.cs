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
    public partial class UC_Donhang : UserControl
    {
        public UC_Donhang()
        {
            InitializeComponent();
            Load += UC_Donhang_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string giaStr = row.Cells["Gia"].Value?.ToString();
                string soLuongStr = row.Cells["SoLuong"].Value?.ToString();

                if (decimal.TryParse(giaStr, out decimal gia) && int.TryParse(soLuongStr, out int sl))
                {
                    row.Cells["ThanhTien"].Value = (gia * sl).ToString();
                }
                else
                {
                    row.Cells["ThanhTien"].Value = "";
                }
            }
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "SoLuong")
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= onlyDigit_KeyPress;
                    tb.KeyPress += onlyDigit_KeyPress;
                }
            }
        }

        private void onlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void UC_Donhang_Load(object sender, EventArgs e)
        {
            // Thêm cột Mã SP, Tên SP, Giá nếu chưa có
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("MaSP", "Mã SP");
                dataGridView1.Columns.Add("TenSP", "Tên SP");
                dataGridView1.Columns.Add("Gia", "Giá");
            }

            // Thêm cột Số lượng
            if (dataGridView1.Columns["SoLuong"] == null)
            {
                DataGridViewTextBoxColumn soLuongColumn = new DataGridViewTextBoxColumn();
                soLuongColumn.HeaderText = "Số lượng";
                soLuongColumn.Name = "SoLuong";
                dataGridView1.Columns.Add(soLuongColumn);
            }

            // Thêm cột Thành tiền
            if (dataGridView1.Columns["ThanhTien"] == null)
            {
                DataGridViewTextBoxColumn thanhTienColumn = new DataGridViewTextBoxColumn();
                thanhTienColumn.HeaderText = "Thành tiền";
                thanhTienColumn.Name = "ThanhTien";
                thanhTienColumn.ReadOnly = true;
                dataGridView1.Columns.Add(thanhTienColumn);
            }

            // Thêm cột nút Xóa
            if (dataGridView1.Columns["Xoa"] == null)
            {
                DataGridViewButtonColumn btnXoaColumn = new DataGridViewButtonColumn();
                btnXoaColumn.HeaderText = "Xóa";
                btnXoaColumn.Name = "Xoa";
                btnXoaColumn.Text = "Xóa";
                btnXoaColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnXoaColumn);
            }

            // Dữ liệu mẫu
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Rows.Add("SP001", "Chuột máy tính", "150000", "", "", "");
                dataGridView1.Rows.Add("SP002", "Bàn phím cơ", "800000", "", "", "");
            }
            // Chỉ cho phép chỉnh sửa cột "Số lượng", khóa các cột còn lại
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name == "SoLuong")
                    col.ReadOnly = false;
                else
                    col.ReadOnly = true;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (colName == "Xoa")
                {
                    // Xóa dòng
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
