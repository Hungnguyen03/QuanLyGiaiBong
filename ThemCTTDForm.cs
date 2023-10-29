﻿using Bunifu.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace QuanLyGiaiBong
{
    public partial class ThemCTTDForm : Form
    {
         ProcessDataBase dtBase = new ProcessDataBase();
        string madoikhach,madoinha,matrandau, tenDoiNha, tenDoiKhach;
        public ThemCTTDForm(int MaTd)
        {
            InitializeComponent();
            matrandau= MaTd.ToString();
        }

        private void TenDoiDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            TenCTDropDown.SelectedIndex = -1;
            DoDropDown.SelectedIndex = -1;
            VangDropDown.SelectedIndex = -1;
            DSCT();
        }

        private void ThemCTTDForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT MaTranDau, DB1.TenDoi AS TenDoiNha, DB2.TenDoi AS TenDoiKhach,DB1.MaDoi AS MaDoiKhach,DB2.MaDoi AS MaDoiNha ,DB1.Logo AS AnhDN,DB2.Logo AS AnhDK " +
                                 "FROM TranDau AS TD " +
                                 "JOIN DoiBong AS DB1 ON TD.MaDoiNha = DB1.MaDoi " +
                                 "JOIN DoiBong AS DB2 ON TD.MaDoiKhach = DB2.MaDoi "+
                                   "WHERE TD.MaTranDau = " + matrandau;

            DataTable result = dtBase.DocBang(query);

            if (result != null && result.Rows.Count > 0)
            {
                tenDoiNha = result.Rows[0]["TenDoiNha"].ToString();
                tenDoiKhach = result.Rows[0]["TenDoiKhach"].ToString();

                TenDoiNhaLabel.Text = tenDoiNha;
                TenDoiKhachLabel.Text = tenDoiKhach;

                madoikhach = result.Rows[0]["MaDoiKhach"].ToString();
                madoinha = result.Rows[0]["MaDoiNha"].ToString();
                matrandau = result.Rows[0]["MaTranDau"].ToString();
                TenDoiDropDown.Items.AddRange(
                   new String[]
                   {
                        tenDoiNha,
                        tenDoiKhach,
                   });


                string appPath = Application.StartupPath;
                string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\..")); 
                string imagePath = Path.Combine(projectRootPath, "Images", "DoiBong");
                string anhDNPath = Path.Combine(imagePath, result.Rows[0]["AnhDN"].ToString());
                string anhDKPath = Path.Combine(imagePath, result.Rows[0]["AnhDK"].ToString());


                if (File.Exists(anhDNPath) && File.Exists(anhDKPath))
                {
                    // Load và hiển thị ảnh
                    DoiNhaPicture.WaitOnLoad = true;
                    FileStream streamDN = new FileStream(anhDNPath, FileMode.Open);
                    FileStream streamDK = new FileStream(anhDKPath, FileMode.Open);
                    Bitmap bitmapDN = new Bitmap(streamDN);
                    Bitmap bitmapDK = new Bitmap(streamDK);
                    DoiNhaPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    DoiNhaPicture.Image = (Image)bitmapDN;
                    DoiKhachPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    DoiKhachPicture.Image = (Image)bitmapDK;

                }
            }
            result.Dispose();
            DSCT();
        }
        private void DSCT()
        {
            TenCTDropDown.Items.Clear();
            DoDropDown.Items.Clear();
            VangDropDown.Items.Clear();


            if (TenDoiDropDown.SelectedItem != null)
            {
                string selectedTeam = TenDoiDropDown.SelectedItem.ToString();
                string queryTenCT = "";

                if (selectedTeam == tenDoiNha)
                {
                    queryTenCT = "select TenCT from CauThu " +
                        "join TranDau_CauThu on CauThu.MaCT = TranDau_CauThu.MaCauThu " +
                        "join DoiBong on DoiBong.MaDoi = TranDau_CauThu.MaDoi " +
                        "where DoiBong.TenDoi=N'"+tenDoiNha+"' AND TranDau_CauThu.MaTranDau = " + matrandau;
                }
                else if (selectedTeam == tenDoiKhach)
                {
                    queryTenCT = "select TenCT from CauThu " +
                       "join TranDau_CauThu on CauThu.MaCT = TranDau_CauThu.MaCauThu " +
                       "join DoiBong on DoiBong.MaDoi = TranDau_CauThu.MaDoi " +
                       "where DoiBong.TenDoi=N'" + tenDoiKhach + "' AND TranDau_CauThu.MaTranDau = " + matrandau;
                }

                DataTable dsCT = dtBase.DocBang(queryTenCT);

                if (dsCT != null && dsCT.Rows.Count > 0)
                {
                    foreach (DataRow row in dsCT.Rows)
                    {
                        string tenCauThu = row["TenCT"].ToString();
                        TenCTDropDown.Items.Add(tenCauThu);
                        DoDropDown.Items.Add(tenCauThu);
                        VangDropDown.Items.Add(tenCauThu);
                    }

                    dsCT.Dispose();
                }
            }
        }

        private void DSDoiKhachBtn_Click(object sender, EventArgs e)
        {
            DSCauThuThiDauForm dsCauThuForm = new DSCauThuThiDauForm(madoikhach,matrandau);
            dsCauThuForm.Show();
        }

        private void DSDoiNhaBtn_Click(object sender, EventArgs e)
        {
            DSCauThuThiDauForm dsCauThuForm = new DSCauThuThiDauForm(madoinha,matrandau);
            dsCauThuForm.Show();
        }

    }
    }
    
