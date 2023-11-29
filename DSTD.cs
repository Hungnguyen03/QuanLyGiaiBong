using System;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLyGiaiBong
{
    public partial class DSTD : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public DSTD()
        {
            InitializeComponent();
        }
        private void DSTD_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void ReloadData()
        {
            getData();
        }


        private void getData()
        {
            DataTable dtTranDau = dtBase.DocBang("SELECT Luotdau, DB1.TenDoi AS TenDoiNha,SoBanThangDoiNha,SoBanThuaDoiNha," +
                "DB2.TenDoi AS TenDoiKhach, SoTheDoDoiNha, MaTranDau " +
                "FROM TranDau INNER JOIN DoiBong DB1 ON TranDau.MaDoiNha = DB1.MaDoi " +
                "INNER JOIN DoiBong DB2 ON TranDau.MaDoiKhach = DB2.MaDoi");
            dgvDSTD.DataSource = dtTranDau;
            dgvDSTD.Columns["MaTranDau"].Visible = false;
            //Định dạng dataGrid
            dgvDSTD.Columns["Luotdau"].HeaderText = "Lượt đấu";
            dgvDSTD.Columns["TenDoiNha"].HeaderText = "Đội nhà";
            dgvDSTD.Columns[2].HeaderText = "  ";
            dgvDSTD.Columns[3].HeaderText = "  ";
            dgvDSTD.Columns["TenDoiKhach"].HeaderText = "Đội khách";
            dgvDSTD.Columns["SoTheDoDoiNha"].HeaderText = "Thẻ đỏ ĐN";
            dgvDSTD.Columns[0].Width = 100;
            dgvDSTD.Columns[5].Width = 100;
            dgvDSTD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTD.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTD.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTD.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTD.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDSTD.Columns[1].Width = 250;
            //dgvDSTD.BackgroundColor = Color.LightBlue;
            dtTranDau.Dispose();//Giải phóng bộ nhớ cho DataTable
        }

        private void dgvDSTD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
                DataGridViewRow selectedTD = dgvDSTD.Rows[e.RowIndex];
                int maTD = Convert.ToInt32(selectedTD.Cells["MaTranDau"].Value);

                ChiTietTranDau ctTD = new ChiTietTranDau(maTD);
                ctTD.ShowDialog();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT Luotdau, DB1.TenDoi AS TenDoiNha,SoBanThangDoiNha,SoBanThuaDoiNha,DB2.TenDoi AS TenDoiKhach, SoTheDoDoiNha, MaTranDau " +
                "FROM TranDau INNER JOIN DoiBong DB1 ON TranDau.MaDoiNha = DB1.MaDoi " +
                "INNER JOIN DoiBong DB2 ON TranDau.MaDoiKhach = DB2.MaDoi";
            //Khi chọn tiêu chí nào sẽ ghép với tiêu chí đó bằng từ and
            //Tìm kiếm gần đúng với từ khóa like
            if (txbDN.Text != "")
                sql = sql + " and DB1.TenDoi like N'%" + txbDN.Text.Trim() + "%'";
            if (txbSBT.Text != "")
                sql = sql + " and SoBanThangDoiNha = '" + txbSBT.Text.Trim() + "'";
            if (txbSTD.Text != "")
                sql = sql + " and SoTheDoDoiNha = '" + txbSTD.Text.Trim() + "'";
            //Trình bày gridView
            DataTable dtCauThu = dtBase.DocBang(sql);
            dgvDSTD.DataSource = null;
            dgvDSTD.DataSource = dtCauThu;
            dgvDSTD.Columns["MaTranDau"].Visible = false;
            dgvDSTD.Columns[0].HeaderText = "Lượt đấu";
            dgvDSTD.Columns[1].HeaderText = "Đội nhà";
            dgvDSTD.Columns[2].HeaderText = "  ";
            dgvDSTD.Columns[3].HeaderText = "  ";
            dgvDSTD.Columns[4].HeaderText = "Đội khách";
            dgvDSTD.Columns[5].HeaderText = "Thẻ đỏ ĐN";
            dgvDSTD.Columns[0].Width = 100;
            dgvDSTD.Columns[5].Width = 100;
            dgvDSTD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTD.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTD.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTD.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSTD.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

		private void add_Click(object sender, EventArgs e)
		{
				AddTranDau TD = new AddTranDau();
                TD.FormClosed += AddTranDau_FormClosed;
                TD.ShowDialog();
		}
        private void AddTranDau_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadData();
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDSTD.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDSTD.SelectedRows[0];
                int maTD = Convert.ToInt32(selectedRow.Cells["MaTranDau"].Value);
                ThemCTTDForm cttd = new ThemCTTDForm(maTD);

                cttd.FormClosed += ThemCTTDForm_FormClosed;

                cttd.ShowDialog();
            }
        }
        private void ThemCTTDForm_FormClosed(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvDSTD.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDSTD.SelectedRows[0];
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
                exSheet.Range["D4"].Value = "Kết quả trận đấu";

                //In các thông tin chung
                exSheet.Range["A6:G6"].Font.Size = 12;
                exSheet.Range["A6:G6"].ColumnWidth = 30;
                exSheet.Range["A6:G6"].Font.Bold = true;
                exSheet.Range["A6:G6"].Font.Color = Color.Black;

                exSheet.Range["A6"].Value = "Lượt đấu";
                exSheet.Range["B6"].Value = "Đội nhà";
                exSheet.Range["C6"].Value = "Bàn thắng đội nhà";
                exSheet.Range["D6"].Value = "Bàn thắng đội khách";
                exSheet.Range["E6"].Value = "Đội khách";
                exSheet.Range["F6"].Value = "Số thẻ đỏ đội nhà";
                //In danh sách các chi tiết nhân viên
                int dong = 7;
                exSheet.Range["A" + dong.ToString()].Value = selectedRow.Cells["Luotdau"].Value.ToString();
                exSheet.Range["B" + dong.ToString()].Value = selectedRow.Cells["TenDoiNha"].Value.ToString();
                exSheet.Range["C" + dong.ToString()].Value = selectedRow.Cells["SoBanThangDoiNha"].Value.ToString();
                exSheet.Range["D" + dong.ToString()].Value = selectedRow.Cells["SoBanThuaDoiNha"].Value.ToString();
                exSheet.Range["E" + dong.ToString()].Value = selectedRow.Cells["TenDoiKhach"].Value.ToString();
                exSheet.Range["F" + dong.ToString()].Value = selectedRow.Cells["SoTheDoDoiNha"].Value.ToString();
                exSheet.Range["F" + 10.ToString()].Value = "Được thực hiển bởi quản lý";
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
}
