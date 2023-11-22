using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void DSCT_Load(object sender, EventArgs e)
        {
            DataTable dtCauThu = dtBase.DocBang("select Anh, TenCT,TenViTri, TenDoi,CauThu.SoBanThang,MaCT from CauThu " +
                "inner join DoiBong on CauThu.MaDoi = DoiBong.MaDoi " +
                "inner join ViTri on CauThu.MaViTri=ViTri.MaViTri");
            dgvDSCT.DataSource = dtCauThu;
            //Định dạng dataGrid
            dgvDSCT.Columns[0].HeaderText = "Ảnh";
            dgvDSCT.Columns[1].HeaderText = "Tên cầu thủ";
            dgvDSCT.Columns[2].HeaderText = "Vị trí";
            dgvDSCT.Columns[3].HeaderText = "Tên đội bóng";
            dgvDSCT.Columns[4].HeaderText = "Số bàn thắng";
            dgvDSCT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns[4].Width = 120;

            //dgvDSCT.Size= new Size(600 ,600);
            //dgvDSCT.BackgroundColor = Color.LightBlue;
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
            dgvDSCT.Columns[0].HeaderText = "Ảnh";
            dgvDSCT.Columns[1].HeaderText = "Tên cầu thủ";
            dgvDSCT.Columns[2].HeaderText = "Vị trí";
            dgvDSCT.Columns[3].HeaderText = "Tên đội bóng";
            dgvDSCT.Columns[4].HeaderText = "Số bàn thắng";
            dgvDSCT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSCT.Columns[4].Width = 120;
            dgvDSCT.Columns["MaCT"].Visible = false;
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
    }
}
