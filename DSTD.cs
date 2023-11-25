using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyGiaiBong.ProcessDataBase;

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
            dgvDSTD.Columns["SoTheDoDoiNha"].HeaderText = "Số thẻ đỏ";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDSTD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
            dgvDSTD.Columns[5].HeaderText = "Số thẻ đỏ";
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
				TD.ShowDialog();

		}

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDSTD.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDSTD.SelectedRows[0];
                int maTD = Convert.ToInt32(selectedRow.Cells["MaTranDau"].Value);
                ThemCTTDForm cttd = new ThemCTTDForm(maTD);
                cttd.ShowDialog();
            }
        }
    }
}
