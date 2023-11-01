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
            DataTable dtCauThu = dtBase.DocBang("select Anh, TenDoi, TenCT, ViTri  from CauThu inner join DoiBong on CauThu.MaDoi = DoiBong.MaDoi");
            dgvDSCT.DataSource = dtCauThu;
            //Định dạng dataGrid
            //dgvDSCT.Columns[0].HeaderText = "Ten Cau Thu";
            //dgvDSCT.Columns[1].HeaderText = "So Ban Thang";
            
            //dgvDSCT.Size= new Size(600 ,600);
            //dgvDSCT.BackgroundColor = Color.LightBlue;
            dtCauThu.Dispose();//Giải phóng bộ nhớ cho DataTable
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select Anh, TenDoi, TenCT, ViTri  from CauThu inner join DoiBong on CauThu.MaDoi = DoiBong.MaDoi";
            //Khi chọn tiêu chí nào sẽ ghép với tiêu chí đó bằng từ and
            //Tìm kiếm gần đúng với từ khóa like
            if (txbTCT.Text != "")
                sql = sql + " and TenCT like N'%" + txbTCT.Text.Trim() + "%'";
            if (txbDB.Text != "")
                sql = sql + " and TenDoi like N'%" + txbDB.Text.Trim() + "%'";
            //if (txbSBT.Text != "")
            //sql = sql + " and TenDoi like N'%" + txbDB.Text.Trim() + "%'";
            //Trình bày gridView
            DataTable dtCauThu = dtBase.DocBang(sql);
            dgvDSCT.DataSource = null;
            dgvDSCT.DataSource = dtCauThu;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
