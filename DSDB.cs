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
    public partial class DSDB : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public DSDB()
        {
            InitializeComponent();
        }

        private void DSDB_Load(object sender, EventArgs e)
        {
            DataTable dtDoiBong = dtBase.DocBang("select LoGo,Tendoi,HLV,Diem,Madoi from DoiBong");
            dgvDSDB.DataSource = dtDoiBong;
            dgvDSDB.Columns["Madoi"].Visible = false;
            //Định dạng dataGrid
            dgvDSDB.Columns[0].HeaderText = "Logo";
            dgvDSDB.Columns[1].HeaderText = "Tên đội bóng";
            dgvDSDB.Columns[2].HeaderText = "Huấn luyện viên";
            dgvDSDB.Columns[3].HeaderText = "Điểm";
            dgvDSDB.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSDB.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSDB.Columns[3].Width = 70;
            //dgvDSDB.Columns[1].Width = 250;
            //dgvDSDB.BackgroundColor = Color.LightBlue;
            dtDoiBong.Dispose();
        }

        private void dgvDSDB_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
            {
                DataGridViewRow selectedDB = dgvDSDB.Rows[e.RowIndex];
                int maDB = Convert.ToInt32(selectedDB.Cells["Madoi"].Value);


                ClubDetail ctDB = new ClubDetail(maDB);
                ctDB.ShowDialog();
            }
        }
    }
}
