using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class ClubDetail : Form
    {
        connectDB conn = new connectDB();
        public ClubDetail()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClubDetail_Load(object sender, EventArgs e)
        {
            DataTable dataTable = conn.DocBang("select MaCT,MaDoi,TenCT,ViTri,NgaySinh,SoAo from CauThu where madoi = 1");
            DsCauThu.DataSource= dataTable;
            DsCauThu.Columns[0].HeaderText = "Mã CT";
            DsCauThu.Columns[1].HeaderText = "Mã DB";
            DsCauThu.Columns[2].HeaderText = "Họ tên";
            DsCauThu.Columns[3].HeaderText = "Vị trí";
            DsCauThu.Columns[4].HeaderText = "Ngày sinh";
            DsCauThu.Columns[5].HeaderText = "Số áo";

            DsCauThu.Columns[0].Width = 30;
            DsCauThu.Columns[1].Width = 30;
            DsCauThu.Columns[2].Width = 250;
            DsCauThu.Columns[3].Width = 100;
            DsCauThu.Columns[4].Width = 200;
            DsCauThu.Columns[5].Width = 50;

            dataTable.Dispose();
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
