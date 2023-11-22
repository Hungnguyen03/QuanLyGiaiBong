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
    public partial class VPL : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public VPL()
        {
            InitializeComponent();
        }

        private void VPL_Load(object sender, EventArgs e)
        {
            DataTable dtVua = dtBase.DocBang("SELECT TOP 3 Anh, TenCT,TenViTri, SoBanThang FROM CauThu inner join ViTri on CauThu.MaViTri=ViTri.MaViTri ORDER BY SoBanThang DESC");
            dgvVPL.DataSource = dtVua;
            dgvVPL.Columns[0].HeaderText = "Ảnh";
            dgvVPL.Columns[1].HeaderText = "Tên cầu thủ";
            dgvVPL.Columns[2].HeaderText = "Vị trí";
            dgvVPL.Columns[3].HeaderText = "Số bàn thắng";
            dgvVPL.Columns[3].Width = 125;
            dgvVPL.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVPL.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVPL.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


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
    }
}
