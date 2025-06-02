using Formcustomer.customer;
namespace Formcustomer

{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uC_Lichsudonhang1 = new Formcustomer.customer.UC_Lichsudonhang();
            this.uC_Thongtincanhan1 = new Formcustomer.customer.UC_Thongtincanhan();
            this.uC_Danhgia1 = new Formcustomer.customer.UC_Danhgia();
            this.uC_Donhang1 = new Formcustomer.customer.UC_Donhang();
            this.uC_Sanpham1 = new Formcustomer.customer.UC_Sanpham();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 56);
            this.panel1.TabIndex = 18;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(708, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            this.lblTime.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 9;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(233, 11);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(396, 41);
            this.guna2TextBox1.TabIndex = 3;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống mua hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 394);
            this.panel2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(28, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Thông tin cá nhân";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(28, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 35);
            this.button7.TabIndex = 9;
            this.button7.Text = "Đơn hàng";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(215, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 441);
            this.panel3.TabIndex = 20;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(28, 145);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(170, 35);
            this.button10.TabIndex = 19;
            this.button10.Text = "Lịch sử mua hàng";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(28, 213);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 35);
            this.button9.TabIndex = 18;
            this.button9.Text = "Đánh giá";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.button15);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 320);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(217, 74);
            this.panel7.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.Location = new System.Drawing.Point(52, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 21);
            this.label15.TabIndex = 6;
            this.label15.Text = "Customer@gmail.com";
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI Black", 8F);
            this.button15.Location = new System.Drawing.Point(4, 29);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(42, 26);
            this.button15.TabIndex = 4;
            this.button15.Text = "CUS";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(19, 145);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 27);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(28, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "Sản phẩm";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(19, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 26);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(19, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 24);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.uC_Lichsudonhang1);
            this.panel4.Controls.Add(this.uC_Thongtincanhan1);
            this.panel4.Controls.Add(this.uC_Danhgia1);
            this.panel4.Controls.Add(this.uC_Donhang1);
            this.panel4.Controls.Add(this.uC_Sanpham1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(217, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 394);
            this.panel4.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // uC_Lichsudonhang1
            // 
            this.uC_Lichsudonhang1.BackColor = System.Drawing.Color.White;
            this.uC_Lichsudonhang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Lichsudonhang1.Location = new System.Drawing.Point(0, 0);
            this.uC_Lichsudonhang1.Name = "uC_Lichsudonhang1";
            this.uC_Lichsudonhang1.Size = new System.Drawing.Size(699, 394);
            this.uC_Lichsudonhang1.TabIndex = 4;
            // 
            // uC_Thongtincanhan1
            // 
            this.uC_Thongtincanhan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Thongtincanhan1.Location = new System.Drawing.Point(0, 0);
            this.uC_Thongtincanhan1.Name = "uC_Thongtincanhan1";
            this.uC_Thongtincanhan1.Size = new System.Drawing.Size(699, 394);
            this.uC_Thongtincanhan1.TabIndex = 3;
            // 
            // uC_Danhgia1
            // 
            this.uC_Danhgia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Danhgia1.Location = new System.Drawing.Point(0, 0);
            this.uC_Danhgia1.Name = "uC_Danhgia1";
            this.uC_Danhgia1.Size = new System.Drawing.Size(699, 394);
            this.uC_Danhgia1.TabIndex = 2;
            this.uC_Danhgia1.Load += new System.EventHandler(this.uC_Danhgia1_Load);
            // 
            // uC_Donhang1
            // 
            this.uC_Donhang1.BackColor = System.Drawing.Color.White;
            this.uC_Donhang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Donhang1.Location = new System.Drawing.Point(0, 0);
            this.uC_Donhang1.Name = "uC_Donhang1";
            this.uC_Donhang1.Size = new System.Drawing.Size(699, 394);
            this.uC_Donhang1.TabIndex = 1;
            this.uC_Donhang1.Load += new System.EventHandler(this.uC_Donhang1_Load);
            // 
            // uC_Sanpham1
            // 
            this.uC_Sanpham1.BackColor = System.Drawing.Color.White;
            this.uC_Sanpham1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Sanpham1.Location = new System.Drawing.Point(0, 0);
            this.uC_Sanpham1.Name = "uC_Sanpham1";
            this.uC_Sanpham1.Size = new System.Drawing.Size(699, 394);
            this.uC_Sanpham1.TabIndex = 0;
            this.uC_Sanpham1.Load += new System.EventHandler(this.uC_Sanpham1_Load_1);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.Formcustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private UC_Sanpham uC_Sanpham1;
        private UC_Donhang uC_Donhang1;
        private UC_Danhgia uC_Danhgia1;
        private UC_Thongtincanhan uC_Thongtincanhan1;
        private System.Windows.Forms.Timer timer1;
        private UC_Lichsudonhang uC_Lichsudonhang1;
        private System.Windows.Forms.Label lblTime;
    }
}

