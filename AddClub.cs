using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class AddClub : Form
    {
        ProcessDataBase conn = new ProcessDataBase();
        public AddClub()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void EmptyText()
        {
            txtAddTenSan.Text = "";
            txtAddTenDoi.Text = "";
            txtAddHLV.Text = "";
            txtAddTinh.Text = "";
            
        }
        private void check_MS()
        {
            DataTable get_ms = conn.DocBang("select masan from SanBong where tensan like concat('%',N'" + txtAddTenSan.Text + "')");
            if(get_ms.Rows.Count == 0)
            {
                conn.CapNhatDuLieu("insert into sanbong(tensan) values(N'" + txtAddTenSan.Text + "')");
            }
            else
            {

            }
            get_ms.Dispose();
        }
        private void check_MT()
        {
            DataTable get_mt = conn.DocBang("select matinh from tinh where tentinh like N'"+txtAddTinh.Text+"'");
            int check_mt = int.Parse(get_mt.Rows[0]["matinh"].ToString());
            if (get_mt.Rows.Count == 0)
            {
                conn.CapNhatDuLieu("insert into Tinh(tentinh) values(N'" + txtAddTinh.Text + "')");
            }
            else 
            { 
            
            }
            get_mt.Dispose();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtAddTenSan.Text.Trim() == "" || txtAddTenDoi.Text == "" ||
                txtAddHLV.Text == "" || txtAddTinh.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin đội bóng!");
                txtAddTenDoi.Focus();
            }
            else
            {
                check_MS();
                check_MT();
                DataTable get_ms = conn.DocBang("select masan from SanBong where tensan like concat('%',N'" + txtAddTenSan.Text + "')");
                int MS = int.Parse(get_ms.Rows[0]["masan"].ToString());
                DataTable get_mt = conn.DocBang("select matinh from tinh where tentinh like N'" + txtAddTinh.Text + "'");
                int MT = int.Parse(get_mt.Rows[0]["matinh"].ToString());

                DataTable dt = new DataTable();
                conn.CapNhatDuLieu("insert into DoiBong(TenDoi,MaSan,HLV,MaTinh,Logo) " +
                    "values(N'" + txtAddTenDoi.Text + "'," +
                    "" + MS + "," +
                    "N'" + txtAddHLV.Text + "'," +
                    "" + MT + "," +
                    "'" + txtLogoLink.Text + "')");

                MessageBox.Show("New club added!");
                get_ms.Dispose();
                get_mt.Dispose();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            EmptyText();
        }

        private void btn_choosePic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    txtLogoLink.Text = imagePath;
                    logoPic.Image = Image.FromFile(imagePath);
                }
            }
            OpenFileDialog getPic = new OpenFileDialog();
            getPic.Title = "Chọn hình ảnh";
            getPic.InitialDirectory = "C:\\";
            getPic.Filter = "Ảnh (*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";

            if (getPic.ShowDialog() == DialogResult.OK)
            {
                string filePath = getPic.FileName;
                txtLogoLink.Text = filePath;

                Bitmap img = new Bitmap(filePath);

                int width = pbAnh.Width;
                int height = pbAnh.Height;
                Size newSize = new Size(width, height);
                img.SetResolution(newSize.Width, newSize.Height);

                pbAnh.Image = img;
            }
        }

        private void txtAddTenDoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogoLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
