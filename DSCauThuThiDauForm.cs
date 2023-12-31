﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class DSCauThuThiDauForm : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        string MaDoi,MaTranDau;
        List<string> selectedPlayerNames = new List<string>();
        public DSCauThuThiDauForm(string madoi, string matrandau)
        {
            InitializeComponent();
            MaDoi =madoi;
            MaTranDau = matrandau;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void DSCauThuThiDauForm_Load(object sender, EventArgs e)
        {
            string query = "Select TenCT, TenViTri , SoAo,MaCT from CauThu join ViTri ON ViTri.MaViTri = CauThu.MaViTri where MaDoi = '" + MaDoi + "'";
            DataTable dsCauthu = dtBase.DocBang(query); 
            dgvDSCauThu.DataSource = dsCauthu;
            //Định dạng dataGrid
            dgvDSCauThu.Columns[1].HeaderText = "Tên cầu thủ";
            dgvDSCauThu.Columns[2].HeaderText = "Vị trí";
            dgvDSCauThu.Columns[3].HeaderText = "Số áo";
            dsCauthu.Dispose();

        }

        private void GetSelectedPlayers()
        {
            selectedPlayerNames.Clear();
            foreach (DataGridViewRow row in dgvDSCauThu.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells[0];
                if (checkBox.Value != null && (bool)checkBox.Value)
                {
                    string maCT = row.Cells["MaCT"].Value.ToString();
                    string viTri = row.Cells["TenViTri"].Value.ToString();

                    selectedPlayerNames.Add(maCT);
                    selectedPlayerNames.Add(MaDoi); 
                    selectedPlayerNames.Add(MaTranDau);
                    selectedPlayerNames.Add(viTri);
                }
            }

 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LuuBtn_Click(object sender, EventArgs e)
        {
            GetSelectedPlayers();

            if (selectedPlayerNames.Count > 0)
            {
                // Sử dụng vòng lặp để thêm từng cầu thủ vào cơ sở dữ liệu
                for (int i = 0; i < selectedPlayerNames.Count; i += 4) 
                {
                    string maCauThu = selectedPlayerNames[i];
                    string viTri = selectedPlayerNames[i + 3];
                    string maDoi = selectedPlayerNames[i + 1];
                    string maTranDau = selectedPlayerNames[i + 2];

                    // Thực hiện câu lệnh SQL để thêm cầu thủ vào cơ sở dữ liệu
                    string sql = "INSERT INTO TranDau_CauThu (MaTranDau, MaDoi, MaCauThu, ViTri) " +
                             "VALUES (N'"+ maTranDau +"', N'"+ maDoi +"', N'"+ maCauThu +"', N'"+ viTri +"')";
                    dtBase.CapNhatDuLieu(sql);
                    // Update  Số lần ra sân
                    string updatePlayerSql = "update CauThu set SoLanRaSan = (select COUNT(*) from TranDau_CauThu where MaCT = MaCauThu)";
                    dtBase.CapNhatDuLieu(updatePlayerSql);
                }

                MessageBox.Show("Thêm cầu thủ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không có cầu thủ nào được chọn.", "Chưa chọn cầu thủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
