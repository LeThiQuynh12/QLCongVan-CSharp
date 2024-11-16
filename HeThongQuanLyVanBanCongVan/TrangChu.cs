using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyVanBanCongVan
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnQuanLyVanBan_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnQuanLyVbNoiBo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnTimKiemThongKe_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

      

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Kiểm tra nút chuột trái
            {
                // Tính vị trí bên dưới PictureBox
                var position = pictureBox1.PointToScreen(new Point(0, pictureBox1.Height));

                // Hiển thị ContextMenuStrip tại vị trí tính toán
                contextMenuStrip1.Show(position);
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            // Tính vị trí bên dưới PictureBox
            var position = pictureBox2.PointToScreen(new Point(0, pictureBox2.Height));

            // Hiển thị ContextMenuStrip tại vị trí tính toán
            contextMenuStrip2.Show(position);
        }

        private void sửaThôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

   
    }
}
