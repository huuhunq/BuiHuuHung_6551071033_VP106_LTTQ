using System.Linq;
using Microsoft.EntityFrameworkCore;
using BuiHuuHung_6551071033_VP106_LTTQ.Models;
namespace BuiHuuHung_6551071033_VP106_LTTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvHangHoa.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvHangHoa.MultiSelect = false;
            dgvHangHoa.ReadOnly = true;
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            LoadData();
            TrangThaiBanDau();
        }

        private QL_BanHangContext TaoDbContext()
        {
            string connectionString =
                "Server=localhost;Database=QL_BanHang;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True;";

            var options =
                new DbContextOptionsBuilder<QL_BanHangContext>();

            options.UseSqlServer(connectionString);

            return new QL_BanHangContext(options.Options);
        }

        private void LoadData()
        {
            try
            {
                using (var context = TaoDbContext())
                {
                    dgvHangHoa.DataSource = context.SanPhams
                        .AsNoTracking()
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu: " + ex.Message,
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TrangThaiBanDau()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();

            dgvHangHoa.ClearSelection();
            dgvHangHoa.CurrentCell = null;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
        }
        private bool KiemTraGiaBan()
        {
            double giaBan;

            if (!double.TryParse(txtGiaBan.Text, out giaBan))
            {
                MessageBox.Show("Giá bán phải là số!");
                txtGiaBan.Focus();
                return false;
            }

            if (giaBan <= 0)
            {
                MessageBox.Show("Giá bán phải lớn hơn 0!");
                txtGiaBan.Focus();
                return false;
            }

            return true;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool KiemTra()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Mã sản phẩm không được để trống!");
                txtMaSP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!");
                txtTenSP.Focus();
                return false;
            }
            if (!KiemTraGiaBan())
            {
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
                return;

            if (IsMaSPExists(txtMaSP.Text.Trim()))
            {
                MessageBox.Show(
                    "Mã sản phẩm đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaSP.Focus();
                return;
            }

            try
            {
                using (var context = TaoDbContext())
                {
                    var sanPham = new SanPham
                    {
                        MaSanPham = txtMaSP.Text.Trim(),
                        TenSanPham = txtTenSP.Text.Trim(),
                        GiaBan = txtGiaBan.Text.Trim()
                    };

                    context.SanPhams.Add(sanPham);
                    context.SaveChanges();
                }

                LoadData();
                TrangThaiBanDau();

                MessageBox.Show(
                    "Thêm sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtMaSP.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm sản phẩm: " + ex.Message,
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool IsMaSPExists(string maSP)
        {
            using (var context = TaoDbContext())
            {
                return context.SanPhams.Any(sp => sp.MaSanPham == maSP);
            }
        }

        
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];

            txtMaSP.Text = row.Cells["MaSanPham"].Value?.ToString() ?? "";
            txtTenSP.Text = row.Cells["TenSanPham"].Value?.ToString() ?? "";
            txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString() ?? "";
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            row.Selected = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            if (!KiemTra())
                return;

            try
            {
                using (var context = TaoDbContext())
                {
                    var sanPham = context.SanPhams.Find(txtMaSP.Text.Trim());

                    if (sanPham == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm!");
                        return;
                    }

                    sanPham.TenSanPham = txtTenSP.Text.Trim();
                    sanPham.GiaBan = txtGiaBan.Text.Trim();

                    context.SaveChanges();
                }

                LoadData();
                TrangThaiBanDau();

                MessageBox.Show("Cập nhật sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sản phẩm: " + ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (var context = TaoDbContext())
                {
                    var sanPham = context.SanPhams.Find(txtMaSP.Text.Trim());

                    if (sanPham == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm!");
                        return;
                    }

                    context.SanPhams.Remove(sanPham);
                    context.SaveChanges();
                }

                LoadData();
                TrangThaiBanDau();

                MessageBox.Show("Xóa sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }
    }
}
