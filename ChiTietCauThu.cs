﻿using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class ChiTietCauThu : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        int maCT;
        public ChiTietCauThu(int maCT)
        {
            this.maCT = maCT;
            InitializeComponent();
        }
        private void ChiTietCauThu_Load(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\.."));
            string iconPath = Path.Combine(projectRootPath, "Images", "icons");
            pbVang.Image = Image.FromFile(iconPath + @"\vang.png");
            pbDo.Image = Image.FromFile(iconPath + @"\do.png");
            pbBong.Image = Image.FromFile(iconPath + @"\bong.jpg");
            //Get Data
            getCauThu(maCT, projectRootPath);
            //Set color
            pTitlebar.BackColor = Color.FromArgb(54, 48, 98);
        }

        private void getCauThu(int maCT, string Imagespath)
        {
            DataTable ctCauThu = dtBase.DocBang("select tenCT,vitri.tenvitri,QuocTich.TenQuocTinh,doibong.tendoi,ngaysinh,soao," +
                "solanrasan, sothevang,sothedo,sobanthang,anh from CauThu " +
                "join QuocTinh on QuocTinh.MaQuocTinh = CauThu.MaQuocTich " +
                "join DoiBong on DoiBong.MaDoi = CauThu.MaDoi " +
                " join Vitri on vitri.mavitri = cauthu.mavitri " +
                "Where MaCT = " + maCT);

            if (ctCauThu != null && ctCauThu.Rows.Count > 0)
            {
                lbTen.Text = ctCauThu.Rows[0]["TenCT"].ToString();
                lbViTri.Text = ctCauThu.Rows[0]["TenViTri"].ToString();
                lbQuocTich.Text = ctCauThu.Rows[0]["TenQuocTinh"].ToString();
                lbDoi.Text = ctCauThu.Rows[0]["TenDoi"].ToString();
                DateTime ngaySinh = (DateTime)ctCauThu.Rows[0]["NgaySinh"];
                lbNgaySinh.Text = ngaySinh.ToString("yyyy-MM-dd");
                lbSoAo.Text = ctCauThu.Rows[0]["SoAo"].ToString();
                lbRaSan.Text = ctCauThu.Rows[0]["SoLanRaSan"].ToString();
                lbVang.Text = ctCauThu.Rows[0]["SoTheVang"].ToString();
                lbDo.Text = ctCauThu.Rows[0]["SoTheDo"].ToString();
                lbBanThang.Text = ctCauThu.Rows[0]["SoBanThang"].ToString();
                string cauthuPath = Path.Combine(Imagespath, "Images", "CauThu");
            }

            ctCauThu.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
