namespace BuiHuuHung_6551071033_VP106_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGiaBan = new TextBox();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dgvHangHoa = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 113);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 6;
            label3.Text = "Giá bán(VNĐ):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã sản phẩm:";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(147, 110);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(125, 27);
            txtGiaBan.TabIndex = 4;
            txtGiaBan.TextChanged += textBox3_TextChanged;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(147, 31);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 3;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(147, 72);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(211, 27);
            txtTenSP.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(414, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 146);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(281, 72);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(78, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(184, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(90, 72);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 71);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(78, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHangHoa);
            groupBox3.Location = new Point(12, 175);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 275);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Dock = DockStyle.Bottom;
            dgvHangHoa.Location = new Point(3, 26);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.Size = new Size(770, 246);
            dgvHangHoa.TabIndex = 0;
            dgvHangHoa.CellClick += dgvHangHoa_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản lý bán hàng VP106";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGiaBan;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private GroupBox groupBox3;
        private DataGridView dgvHangHoa;
    }
}
