using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void ClubDetail_Load(object sender, EventArgs e)
        {
            DataTable dataTable = conn.DocBang("select MaCT,MaDoi,TenCT,TenViTri,NgaySinh,SoAo from CauThu join ViTri on ViTri.MaViTri = CauThu.MaViTri where madoi = " + maDB);
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
    }
}
