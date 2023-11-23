using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyGiaiBong.Properties;

namespace QuanLyGiaiBong
{
    public partial class DSCT : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public DSCT()
        {
            InitializeComponent();
            getData();
        }

        private void DSCT_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            DataTable dtCauThu = dtBase.DocBang("select Anh, TenCT,TenViTri, TenDoi,CauThu.SoBanThang,MaCT from CauThu " +
                "inner join DoiBong on CauThu.MaDoi = DoiBong.MaDoi " +
                "inner join ViTri on CauThu.MaViTri=ViTri.MaViTri");
            dgvDSCT.DataSource = dtCauThu;
            //Định dạng dataGrid
            dgvDSCT.Columns["anhCT"].HeaderText = "Ảnh";
            dgvDSCT.Columns["TenCT"].HeaderText = "Tên cầu thủ";
            dgvDSCT.Columns["TenViTri"].HeaderText = "Vị trí";
            dgvDSCT.Columns["TenDoi"].HeaderText = "Tên đội bóng";
            dgvDSCT.Columns["SoBanThang"].HeaderText = "Số bàn thắng";
            dgvDSCT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns["TenDoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns["SoBanThang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns["TenViTri"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns["SoBanThang"].Width = 120;

            dgvDSCT.Columns["Anh"].Visible = false;
            string appPath = Application.StartupPath;
            string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\.."));
            string cauthuPath = Path.Combine(projectRootPath, "Images", "CauThu");
            int slg = dtCauThu.Rows.Count;
            for (var i = 0; i < slg; i++)
            {
                string ctPath = Path.Combine(cauthuPath, dtCauThu.Rows[i]["Anh"].ToString());
                Image anhCT = Image.FromFile(ctPath);
                dgvDSCT["anhCT", i].Value = anhCT;
            }
            dtCauThu.Dispose();//Giải phóng bộ nhớ cho DataTable
            dgvDSCT.Columns["MaCT"].Visible = false;
            dtCauThu.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select Anh,TenCT,TenViTri,TenDoi,CauThu.SoBanThang, MaCT from CauThu " +
                "inner join DoiBong on CauThu.MaDoi = DoiBong.MaDoi " +
                "inner join ViTri on CauThu.MaViTri=ViTri.MaViTri";
            //Khi chọn tiêu chí nào sẽ ghép với tiêu chí đó bằng từ and
            //Tìm kiếm gần đúng với từ khóa like
            if (txbTCT.Text != "")
                sql = sql + " and TenCT like N'%" + txbTCT.Text.Trim() + "%'";
            if (txbDB.Text != "")
                sql = sql + " and TenDoi like N'%" + txbDB.Text.Trim() + "%'";
            if (txbSBT.Text != "")
            sql = sql + " and CauThu.SoBanThang = '" + txbSBT.Text.Trim() + "'";
            //Trình bày gridView
            DataTable dtCauThu = dtBase.DocBang(sql);
            dgvDSCT.DataSource = null;
            dgvDSCT.DataSource = dtCauThu;
            //Định dạng dataGrid
            dgvDSCT.Columns["anhCT"].HeaderText = "Ảnh";
            dgvDSCT.Columns["TenCT"].HeaderText = "Tên cầu thủ";
            dgvDSCT.Columns["TenViTri"].HeaderText = "Vị trí";
            dgvDSCT.Columns["TenDoi"].HeaderText = "Tên đội bóng";
            dgvDSCT.Columns["SoBanThang"].HeaderText = "Số bàn thắng";
            dgvDSCT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns["TenDoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns["SoBanThang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns["TenViTri"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns["SoBanThang"].Width = 120;

            dgvDSCT.Columns["Anh"].Visible = false;
            string appPath = Application.StartupPath;
            string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\.."));
            string cauthuPath = Path.Combine(projectRootPath, "Images", "CauThu");
            int slg = dtCauThu.Rows.Count;
            for (var i = 0; i < slg; i++)
            {
                string ctPath = Path.Combine(cauthuPath, dtCauThu.Rows[i]["Anh"].ToString());
                Image anhCT = Image.FromFile(ctPath);
                dgvDSCT["anhCT", i].Value = anhCT;
            }
            dtCauThu.Dispose();//Giải phóng bộ nhớ cho DataTable
            dgvDSCT.Columns["MaCT"].Visible = false;
            dtCauThu.Dispose();
        }

        private void dgvDSCT_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
                DataGridViewRow selectedCT = dgvDSCT.Rows[e.RowIndex];
                int maCT = Convert.ToInt32(selectedCT.Cells["MaCT"].Value);


                ChiTietCauThu ctCauThu = new ChiTietCauThu(maCT);
                ctCauThu.ShowDialog();
            }
        }

        private void btn_addCT_Click(object sender, EventArgs e)
        {
            AddCauThu addCauThu = new AddCauThu();
            addCauThu.ShowDialog();
        }
    }
}
