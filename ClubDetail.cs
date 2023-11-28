﻿using System;
using System.Drawing;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class ClubDetail : Form
    {
        ProcessDataBase conn = new ProcessDataBase();
        int maDB;
        
        public ClubDetail(int maDB)
        {
            InitializeComponent();
            this.maDB = maDB;
            this.FormBorderStyle = FormBorderStyle.None;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void DemCT(int maDB)
        {
            DataTable dem = conn.DocBang("select count(cauthu.maCT) as Tong from cauthu where madoi = " + maDB);
            txt_demCT.Text = "Số cầu thủ: " + dem.Rows[0]["Tong"].ToString();
        }
        public void getDB(int maDB)
        {
            DataTable ctDB = conn.DocBang("select Logo, Madoi,TenDoi,SanBong.TenSan,HLV,Tinh.TenTinh,Diem,Sobanthang,Sobanthua from Doibong " +
                "join SanBong on Doibong.masan = Sanbong.masan " +
                "join Tinh on Doibong.matinh = tinh.matinh where madoi = " + maDB);
            string appPath = Application.StartupPath;
            string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\.."));
            if (ctDB.Rows.Count == 0)
            {
                MessageBox.Show("Đội bóng không có trong Database!");
            }
            else
            {
                txtTenDoi.Text =ctDB.Rows[0]["TenDoi"].ToString();
                txtTenSan.Text = ctDB.Rows[0]["TenSan"].ToString();
                txtHLV.Text = ctDB.Rows[0]["HLV"].ToString();
                txtTinh.Text = ctDB.Rows[0]["TenTinh"].ToString();
                txtDiem.Text = ctDB.Rows[0]["diem"].ToString();
                txtSoBan.Text = ctDB.Rows[0]["sobanthang"].ToString() + " / " + ctDB.Rows[0]["sobanthua"].ToString();
                string doibongPath = Path.Combine(projectRootPath, "Images", "DoiBong");
                Image anhCT = Image.FromFile(doibongPath + "\\" + ctDB.Rows[0]["Logo"].ToString());
                logo.Image = anhCT;
                logo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            ctDB.Dispose();
        }
        private void ClubDetail_Load(object sender, EventArgs e)
        {
            getDB(maDB);
            DemCT(maDB);
            DataTable dataTable = conn.DocBang("select MaCT,TenCT,vitri.tenvitri,NgaySinh,SoAo from CauThu " +
                "join ViTri on cauthu.mavitri = vitri.mavitri where madoi = " + maDB);
            DsCauThu.DataSource = dataTable;
            DsCauThu.Columns[0].HeaderText = "Mã CT";
            DsCauThu.Columns[1].HeaderText = "Họ tên";
            DsCauThu.Columns[2].HeaderText = "Vị trí";
            DsCauThu.Columns[3].HeaderText = "Ngày sinh";
            DsCauThu.Columns[4].HeaderText = "Số áo";
            DsCauThu.Columns[0].Width = 30;
            DsCauThu.Columns[1].Width = 250;
            DsCauThu.Columns[2].Width = 100;
            DsCauThu.Columns[3].Width = 200;
            DsCauThu.Columns[4].Width = 50;

            dataTable.Dispose();
        }

        private void DsCauThu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
                DataGridViewRow selectedCT = DsCauThu.Rows[e.RowIndex];
                int maCT = Convert.ToInt32(selectedCT.Cells["MaCT"].Value);

                ChiTietCauThu ctCauThu = new ChiTietCauThu(maCT);
                ctCauThu.ShowDialog();
            }
        }
        private void btn_addCT_Click(object sender, EventArgs e)
        {
            AddCauThu new_add = new AddCauThu();
            new_add.ShowDialog();
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
