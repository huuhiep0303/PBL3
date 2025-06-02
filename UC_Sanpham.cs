using System;
using System.Windows.Forms;

namespace Formcustomer.customer
{
    public partial class UC_Sanpham : UserControl
    {
        public UC_Sanpham()
        {
            InitializeComponent();
            Load += UC_Sanpham_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void UC_Sanpham_Load(object sender, EventArgs e)
        {
            // Thêm cột Số lượng nếu chưa có
            if (dataGridView1.Columns["SoLuong"] == null)
            {
                DataGridViewTextBoxColumn soLuongColumn = new DataGridViewTextBoxColumn();
                soLuongColumn.HeaderText = "Số lượng";
                soLuongColumn.Name = "SoLuong";
                dataGridView1.Columns.Add(soLuongColumn);
            }

            // Thêm cột nút Thêm vào đơn hàng nếu chưa có
            if (dataGridView1.Columns["ThemVaoDonHang"] == null)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Thêm vào đơn hàng";
                btnColumn.Name = "ThemVaoDonHang";
                btnColumn.Text = "Thêm";
                btnColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnColumn);
            }

            // Dữ liệu mẫu
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Rows.Add("SP001", "Chuột máy tính", "150000", "1", null);
                dataGridView1.Rows.Add("SP002", "Bàn phím cơ", "800000", "1", null);
            }

            // ✅ Đặt ReadOnly cho từng cột, chỉ mở "SoLuong"
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name == "SoLuong")
                    column.ReadOnly = false;
                else
                    column.ReadOnly = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "ThemVaoDonHang")
            {
                try
                {
                    string maSP = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                    string tenSP = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                    string gia = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                    string soLuongStr = dataGridView1.Rows[e.RowIndex].Cells["SoLuong"].Value?.ToString();

                    int soLuong = int.Parse(soLuongStr);

                    MessageBox.Show($"Đã thêm {soLuong} sản phẩm [{tenSP}] (Mã: {maSP}, Giá: {gia}) vào đơn hàng.", "Thông báo");

                    // TODO: Gọi hàm thêm vào đơn hàng thật sự tại đây
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
