using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            getDanhSach();
        }

        private void DSDB_Load(object sender, EventArgs e)
        {
            getDanhSach();
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

        private void getDanhSach()
        {
            string appPath = Application.StartupPath;
            string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\.."));
            DataTable dtDoiBong = dtBase.DocBang("select Madoi, LoGo, Tendoi,Diem from DoiBong");
            dgvDSDB.DataSource = dtDoiBong;
            dgvDSDB.Columns["Madoi"].Visible = false;
            dgvDSDB.Columns["LoGo"].Visible = false;
            string cauthuPath = Path.Combine(projectRootPath, "Images", "DoiBong");
            int slg = dtDoiBong.Rows.Count;
            for (var i = 0; i < slg; i++)
            {
                string dbPath = Path.Combine(cauthuPath, dtDoiBong.Rows[i]["LoGo"].ToString());
                Image anhDB = Image.FromFile(dbPath);
                dgvDSDB["anhDB", i].Value = anhDB;
            }
            dtDoiBong.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dgvDSDB.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dgvDSDB.SelectedRows[0];
            //    int id = Convert.ToInt32(selectedRow.Cells["Madoi"].Value);
            //    dtBase.CapNhatDuLieu("DELETE FROM DoiBong WHERE MaDoi = " + id);
            //}
            //getDanhSach();
        }
    }
}
