using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }
    }
}
