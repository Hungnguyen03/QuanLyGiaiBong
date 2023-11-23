using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            getData();
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
            getData();
        }
        
        private void getData()
        {
            DataTable ctTranDau = db.DocBang("select * from TranDau" +
                " join DoiBong on TranDau.MaDoiNha = DoiBong.MaDoi" +
                " join SanBong on SanBong.MaSan = DoiBong.MaSan" +
                " where MaTranDau = " + maTD);
            if (ctTranDau != null && ctTranDau.Rows.Count > 0)
            {
                LuotDau.Text = ctTranDau.Rows[0]["LuotDau"].ToString();
                VongDau.Text = ctTranDau.Rows[0]["VongDau"].ToString();
                Goal1.Text = ctTranDau.Rows[0]["SoBanThangDoiNha"].ToString();
                Goal2.Text = ctTranDau.Rows[0]["SoBanThuaDoiNha"].ToString();
                San.Text = ctTranDau.Rows[0]["TenSan"].ToString();
            }
            string appPath = Application.StartupPath;
            string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\.."));
            string doibongPath = Path.Combine(projectRootPath, "Images", "DoiBong");
            //Logo doi nha
            int maDoiNha = Convert.ToInt32(ctTranDau.Rows[0]["MaDoiNha"]);
            DataTable homeLogo = db.DocBang("select Logo from DoiBong where MaDoi = " + maDoiNha);
            Image home = Image.FromFile(doibongPath + "\\" + homeLogo.Rows[0]["Logo"].ToString());
            avt1.Image = home;
            avt1.SizeMode = PictureBoxSizeMode.Zoom;
            //Logo doi khach
            int maDoiKhach = Convert.ToInt32(ctTranDau.Rows[0]["MaDoiKhach"]);
            DataTable awayLogo = db.DocBang("select Logo from DoiBong where MaDoi = " + maDoiKhach);
            Image away = Image.FromFile(doibongPath + "\\" + awayLogo.Rows[0]["Logo"].ToString());
            avt2.Image = away;
            avt2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_addTD_Click(object sender, EventArgs e)
        {
            AddTranDau addTranDau = new AddTranDau();
            addTranDau.ShowDialog();
        }
    }
}
