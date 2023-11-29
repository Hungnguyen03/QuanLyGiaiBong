using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyGiaiBong
{
    public partial class VPL : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public VPL()
        {
            InitializeComponent();
            getData();
        }

        private void VPL_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            DataTable dtVua = dtBase.DocBang("SELECT TOP 3 Anh, TenCT,TenViTri, SoBanThang,MaCT FROM CauThu inner join ViTri on CauThu.MaViTri=ViTri.MaViTri ORDER BY SoBanThang DESC");
            dgvVPL.DataSource = dtVua;
            dgvVPL.Columns["MaCT"].Visible = false;
            dgvVPL.Columns["anhCT"].HeaderText = "Ảnh";
            dgvVPL.Columns["TenCT"].HeaderText = "Tên cầu thủ";
            dgvVPL.Columns["TenViTri"].HeaderText = "Vị trí";
            dgvVPL.Columns["SoBanThang"].HeaderText = "Số bàn thắng";
            dgvVPL.Columns["SoBanThang"].Width = 125;
            dgvVPL.RowTemplate.Height = 125;
            dgvVPL.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVPL.Columns["SoBanThang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVPL.Columns["TenCT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVPL.Columns["TenViTri"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVPL.Columns["Anh"].Visible = false;
            string appPath = Application.StartupPath;
            string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\.."));
            string cauthuPath = Path.Combine(projectRootPath, "Images", "CauThu");
            int slg = dtVua.Rows.Count;
            for (var i = 0; i < slg; i++)
            {
                string ctPath = Path.Combine(cauthuPath, dtVua.Rows[i]["Anh"].ToString());
                Image anhCT = Image.FromFile(ctPath);
                dgvVPL["anhCT", i].Value = anhCT;
            }
            dtVua.Dispose();//Giải phóng bộ nhớ cho DataTable
        }

        private void dgvVPL_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
                DataGridViewRow selectedCT = dgvVPL.Rows[e.RowIndex];
                int maCT = Convert.ToInt32(selectedCT.Cells["MaCT"].Value);


                ChiTietCauThu ctCauThu = new ChiTietCauThu(maCT);
                ctCauThu.ShowDialog();
            }
        }

            //Excel.Application exApp = new Excel.Application();
            //Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            //Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1]; //Thể hiện rằng file này có 1 trang tính
            //Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1]; // Con trỏ chạy vào ô A1 
            //exRange.Font.Size = 15;
            //exRange.Font.Bold = true;
            //exRange.Font.Color = Color.Blue;
            //exRange.Value = "Thông tin chi tiết";

            //exSheet.Range["D4"].Font.Size = 20;
            //exSheet.Range["D4"].Font.Color = Color.Red;
            //exSheet.Range["D4"].Font.Bold = true;
            //exSheet.Range["D4"].Value = "Vua Phá Lưới";

            ////In các thông tin chung
            //exSheet.Range["A6:G6"].Font.Size = 12;
            //exSheet.Range["A6:G6"].ColumnWidth = 30;
            //exSheet.Range["A6:G6"].Font.Bold = true;
            //exSheet.Range["A6:G6"].Font.Color = Color.Black;

            //exSheet.Range["A6"].Value = "Tên cầu thủ";
            //exSheet.Range["B6"].Value = "Vị trí";
            //exSheet.Range["C6"].Value = "Số bàn thắng";
            ////In danh sách các chi tiết nhân viên
            //int dong = 5;
            //for (int i = 0; i < dgvVPL.Rows.Count - 1; i++)
            //{
            //    exSheet.Range["A" + (dong + i).ToString()].Value = dgvVPL.Rows[i].Cells["TenCT"].Value.ToString();
            //    exSheet.Range["B" + (dong + i).ToString()].Value = dgvVPL.Rows[i].Cells["TenViTri"].Value.ToString();
            //    exSheet.Range["C" + (dong + i).ToString()].Value = dgvVPL.Rows[i].Cells["SoBanThang"].Value.ToString();
            //}
            //dong = dong + dgvVPL.Rows.Count;
            //exSheet.Range["D" + dong.ToString()].Value = "Được thực hiển bởi quản lý";
            //exSheet.Name = "Tác phẩm";
            //exBook.Activate();
            ////Lưu file
            //SaveFileDialog save = new SaveFileDialog();
            //if (save.ShowDialog() == DialogResult.OK)
            //{
            //    exBook.SaveAs(save.FileName.ToLower());
            //    MessageBox.Show("Lưu file thành công");
            //}
            //exApp.Quit();
    }
}
