﻿using System;
using System.Drawing;
using System.Data;
using System.IO;
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
            getData();
        }
        public void ReloadData()
        {
            getData();
        }
        private void DSDB_Load(object sender, EventArgs e)
        {
            getData();

        }

        private void getData()
        {
            DataTable dtDoiBong = dtBase.DocBang("select LoGo,Tendoi,HLV,Diem,Madoi from DoiBong");
            dgvDSDB.DataSource = dtDoiBong;
            dgvDSDB.Columns["Madoi"].Visible = false;
            //Định dạng dataGrid
            dgvDSDB.Columns["anhDB"].HeaderText = "Logo";
            dgvDSDB.Columns["Tendoi"].HeaderText = "Tên đội bóng";
            dgvDSDB.Columns["HLV"].HeaderText = "Huấn luyện viên";
            dgvDSDB.Columns["Diem"].HeaderText = "Điểm";
            dgvDSDB.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSDB.Columns["HLV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSDB.Columns["Diem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSDB.Columns["Diem"].Width = 70;
            dgvDSDB.RowTemplate.Height = 100;
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
            updateDiem();
        }
        private void updateDiem()
        {
            dtBase.CapNhatDuLieu("WITH Score AS (SELECT dbo.DoiBong.MaDoi, SUM(CASE WHEN dbo.TranDau.MaDoiNha = dbo.DoiBong.MaDoi AND dbo.TranDau.SoBanThangDoiNha > dbo.TranDau.SoBanThuaDoiNha THEN 3 " +
                    "WHEN dbo.TranDau.MaDoiKhach = dbo.DoiBong.MaDoi AND dbo.TranDau.SoBanThangDoiNha < dbo.TranDau.SoBanThuaDoiNha THEN 3 " +
                    "WHEN dbo.TranDau.SoBanThangDoiNha = dbo.TranDau.SoBanThuaDoiNha THEN 1 ELSE 0 END) AS Diem " +
                    "FROM dbo.DoiBong LEFT JOIN dbo.TranDau ON dbo.DoiBong.MaDoi = dbo.TranDau.MaDoiNha OR dbo.DoiBong.MaDoi = dbo.TranDau.MaDoiKhach GROUP BY dbo.DoiBong.MaDoi) " +
                "UPDATE dbo.DoiBong SET Diem = Score.Diem FROM dbo.DoiBong INNER JOIN Score ON dbo.DoiBong.MaDoi = Score.MaDoi;");
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

        private void btn_addDB_Click(object sender, EventArgs e)
        {
            AddClub addClub = new AddClub();
            addClub.FormClosed += addClub_FormClosed;
            addClub.ShowDialog();
        }
        private void addClub_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadData();
        }

    }
}
