using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void DSDB_Load(object sender, EventArgs e)
        {
            DataTable dtDoiBong = dtBase.DocBang("select Madoi, LoGo, Tendoi,Diem from DoiBong");
            dgvDSDB.DataSource = dtDoiBong;
            dgvDSDB.Columns["Madoi"].Visible = false;
            dgvDSDB.Columns["LoGo"].Visible = false;
            string appPath = Application.StartupPath;
            string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\.."));
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
