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
            DataTable dtTranDau = dtBase.DocBang("select Luotdau,VongDau,MaDoiNha,MaDoiKhach, SoTheDoDoiNha from TranDau");
            dgvDSTD.DataSource = dtTranDau;
            //Định dạng dataGrid
            //dgvDSTD.Columns[0].HeaderText = "Ten Cau Thu";
            //dgvDSTD.Columns[1].HeaderText = "So Ban Thang";
            //dgvDSTD.Columns[0].Width = 150;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select Luotdau,VongDau,MaDoiNha,MaDoiKhach, SoTheDoDoiNha from TranDau";
            //Khi chọn tiêu chí nào sẽ ghép với tiêu chí đó bằng từ and
            //Tìm kiếm gần đúng với từ khóa like
            if (txbDN.Text != "")
                sql = sql + " and TenCT like N'%" + txbDN.Text.Trim() + "%'";
            if (txbSBT.Text != "")
                sql = sql + " and TenDoi like N'%" + txbSBT.Text.Trim() + "%'";
            //if (txbSBT.Text != "")
            //sql = sql + " and TenDoi like N'%" + txbDB.Text.Trim() + "%'";
            //Trình bày gridView
            DataTable dtCauThu = dtBase.DocBang(sql);
            dgvDSTD.DataSource = null;
            dgvDSTD.DataSource = dtCauThu;
            dtCauThu.Dispose();
        }
    }
}
