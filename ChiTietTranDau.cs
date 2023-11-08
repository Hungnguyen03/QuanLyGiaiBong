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


namespace QuanLyGiaiBong
{
    public partial class ChiTietTranDau : Form
    {
        ProcessDataBase db = new ProcessDataBase();
        int maTD;
        public ChiTietTranDau(int maTD)
        {
            this.maTD = maTD;
            InitializeComponent(maTD);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            uC_TK1.BringToFront();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            uC_DH1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable ctTranDau = db.DocBang("SELECT LuotDau, VongDau, SoBanThangDoiNha, SoBanThuaDoiNha, TenSan, DoiBong.LoGo AS LogoDoiNha, DK.LoGo AS LogoDoiKhach FROM TranDau" +
            " JOIN DoiBong ON TranDau.MaDoiNha = DoiBong.MaDoi" +
            " JOIN DoiBong DK ON TranDau.MaDoiKhach = DK.MaDoi" +
            " JOIN SanBong ON SanBong.MaSan = DoiBong.MaSan" +
            " WHERE MaTranDau = " + maTD);

            string appPath = Application.StartupPath;
            string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\.."));
            string doibongPath = Path.Combine(projectRootPath, "Images", "DoiBong");

            if (ctTranDau != null && ctTranDau.Rows.Count > 0)
            {
                LuotDau.Text = ctTranDau.Rows[0]["LuotDau"].ToString();
                VongDau.Text = ctTranDau.Rows[0]["VongDau"].ToString();
                Goal1.Text = ctTranDau.Rows[0]["SoBanThangDoiNha"].ToString();
                Goal2.Text = ctTranDau.Rows[0]["SoBanThuaDoiNha"].ToString();
                San.Text = ctTranDau.Rows[0]["TenSan"].ToString();

                Image logo1 = Image.FromFile(doibongPath + "\\" + ctTranDau.Rows[0]["LogoDoiNha"].ToString());
                avt1.Image = logo1;
                avt1.SizeMode = PictureBoxSizeMode.Zoom;
                Image logo2 = Image.FromFile(doibongPath + "\\" + ctTranDau.Rows[0]["LogoDoiKhach"].ToString());
                avt2.Image = logo2;
                avt2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
