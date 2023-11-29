using System;
using System.Drawing;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
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
            conn.CapNhatDuLieu("UPDATE Doibong SET SoLuongCT = (SELECT COUNT(cauthu.maCT) FROM cauthu WHERE madoi = " + maDB + ") WHERE madoi = " + maDB);
            DataTable dem = conn.DocBang("SELECT SoLuongCT FROM Doibong WHERE madoi = " + maDB);
            txt_demCT.Text = "Số cầu thủ: " + dem.Rows[0]["SoLuongCT"].ToString();
        }
        public void getDB(int maDB)
        {
            DataTable ctDB = conn.DocBang("select Logo, Madoi,TenDoi,SanBong.TenSan,HLV,Tinh.TenTinh,Diem,SoBanThang,SoBanThua from Doibong " +
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
                txtSoBan.Text = ctDB.Rows[0]["SoBanThang"].ToString() + " / " + ctDB.Rows[0]["SoBanThua"].ToString();
                string doibongPath = Path.Combine(projectRootPath, "Images", "DoiBong");
                Image anhCT = Image.FromFile(doibongPath + "\\" + ctDB.Rows[0]["Logo"].ToString());
                logo.Image = anhCT;
                logo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            ctDB.Dispose();
        }
        private void CapNhatTTDoiBong()
        {
            //Cap nhat tong ban thang doi bong
            conn.CapNhatDuLieu("UPDATE DoiBong SET SoBanThang = " +
            "ISNULL((SELECT SUM(SoBanThangDoiNha) FROM TranDau WHERE MaDoiNha = MaDoi),0) + " +
            "ISNULL((SELECT SUM(SoBanThuaDoiNha) FROM TranDau WHERE MaDoiKhach = MaDoi),0)");
            //Cap nhat tong ban thua doi bong
            conn.CapNhatDuLieu("UPDATE DoiBong SET SoBanThua = " +
            "ISNULL((SELECT SUM( ISNULL(SoBanThuaDoiNha,0) ) FROM TranDau WHERE MaDoiNha = MaDoi),0) + " +
            "ISNULL((SELECT SUM( ISNULL(SoBanThangDoiNha,0) ) FROM TranDau WHERE MaDoiKhach = MaDoi),0)");
        }
        private void ClubDetail_Load(object sender, EventArgs e)
        {
            CapNhatTTDoiBong();
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
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1]; //Thể hiện rằng file này có 1 trang tính
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1]; // Con trỏ chạy vào ô A1 
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "Thông tin chi tiết";

            exSheet.Range["D4"].Font.Size = 20;
            exSheet.Range["D4"].Font.Color = Color.Red;
            exSheet.Range["D4"].Font.Bold = true;
            exSheet.Range["D4"].Value = "DS Cầu thủ theo đội bóng";

            //In các thông tin chung
            exSheet.Range["A6:G6"].Font.Size = 12;
            exSheet.Range["A6:G6"].ColumnWidth = 30;
            exSheet.Range["A6:G6"].Font.Bold = true;
            exSheet.Range["A6:G6"].Font.Color = Color.Black;

            exSheet.Range["A6"].Value = "Mã CT";
            exSheet.Range["B6"].Value = "Họ Tên";
            exSheet.Range["C6"].Value = "Vị Trí";
            exSheet.Range["D6"].Value = "Ngày Sinh";
            exSheet.Range["E6"].Value = "Số áo";
            //In danh sách các chi tiết nhân viên
            int dong = 7;
            for (int i = 0; i < DsCauThu.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = DsCauThu.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = DsCauThu.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = DsCauThu.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = DsCauThu.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = DsCauThu.Rows[i].Cells[4].Value.ToString();
            }
            dong = dong + DsCauThu.Rows.Count;
            exSheet.Range["F" + dong.ToString()].Value = "Được thực hiển bởi quản lý";
            exSheet.Name = "Tác phẩm";
            exBook.Activate();
            //Lưu file
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
                MessageBox.Show("Lưu file thành công");
            }
            exApp.Quit();
        }

    }
}
