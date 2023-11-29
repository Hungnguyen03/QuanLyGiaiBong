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
        private bool checkDB()
        {
            bool DB = true;
            DataTable get_DB = conn.DocBang("select MaDoi from DoiBong where Tendoi like N'" + txtAddTenDoi.Text + "'");
            if (get_DB.Rows.Count != 0)
            {
                DB = false;
            }
            return DB;
        }

        private void check_MS()
        {
            DataTable get_ms = conn.DocBang("select masan from SanBong where tensan like concat('%',N'" + txtAddTenSan.Text + "')");
            if (get_ms.Rows.Count == 0)
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
            DataTable get_mt = conn.DocBang("select matinh from tinh where tentinh like N'" + txtAddTinh.Text + "'");
            if (get_mt.Rows.Count == 0)
            {
                conn.CapNhatDuLieu("insert into Tinh(tentinh) values(N'" + txtAddTinh.Text + "')");
            }
            else
            {

            }
            get_mt.Dispose();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtAddTenSan.Text.Trim() == "" || txtAddTenDoi.Text == "" ||
                txtAddHLV.Text == "" || txtAddTinh.Text == "" || pbAnh.Image == null)
            {
                MessageBox.Show("Điền đầy đủ thông tin đội bóng!");
                txtAddTenDoi.Focus();
            }
            else if (checkDB() == false)
            {
                MessageBox.Show("Tên đội bóng đã tồn tại!");
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
                this.Close();
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            EmptyText();
        }

        private void btn_choosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog getPic = new OpenFileDialog();
            getPic.Title = "Chọn hình ảnh";
            getPic.InitialDirectory = "C:\\";
            getPic.Filter = "Ảnh (*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";

            if (getPic.ShowDialog() == DialogResult.OK)
            {
                string filePath = getPic.FileName;
                txtLogoLink.Text = Path.GetFileName(filePath);

                Bitmap img = new Bitmap(filePath);

                int width = pbAnh.Width;
                int height = pbAnh.Height;
                Size newSize = new Size(width, height);
                img.SetResolution(newSize.Width, newSize.Height);

                pbAnh.Image = img;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void pTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
