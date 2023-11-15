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
            getDanhSach();
        }

        private void DSCT_Load(object sender, EventArgs e)
        {
            getDanhSach();
        }

        private void SearchData(string searchValue)
        {
            dgvDSCT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvDSCT.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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

        private void getDanhSach()
        {
            DataTable dtCauThu = dtBase.DocBang("select MaCT, Anh, TenCT, TenViTri, TenDoi from CauThu left join DoiBong on CauThu.MaDoi = DoiBong.MaDoi join ViTri on CauThu.MaViTri = ViTri.MaViTri");
            dgvDSCT.DataSource = dtCauThu;
            dgvDSCT.Columns["MaCT"].Visible = false;
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
            dtCauThu.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dgvDSCT.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dgvDSCT.SelectedRows[0];
            //    int id = Convert.ToInt32(selectedRow.Cells["MaCT"].Value);
            //    dtBase.CapNhatDuLieu("DELETE FROM CauThu WHERE MaDoi = " + id);
            //}
            //getDanhSach();
        }
    }
}
