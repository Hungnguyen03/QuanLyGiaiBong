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
        public int matrandau = 1;
        public ChiTietTranDau()
        {
            InitializeComponent();
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
            Database db = new Database();
            string ldquery = "select LuotDau from TranDau ";
            db.SetQuery(ldquery);
            Dictionary<String,object> ld = db.LoadRow();
            LuotDau.Text = ld["LuotDau"].ToString();

            string vdquery = "select VongDau from TranDau ";
            db.SetQuery(vdquery);
            Dictionary<String, object> vd = db.LoadRow();
            VongDau.Text = vd["VongDau"].ToString();

            string goalNhaquery = "select SoBanThangDoiNha from TranDau ";
            db.SetQuery(goalNhaquery);
            Dictionary<String, object> goalNha = db.LoadRow();
            Goal1.Text = goalNha["SoBanThangDoiNha"].ToString();

            string goalKhachquery = "select SoBanThuaDoiNha from TranDau ";
            db.SetQuery(goalKhachquery);
            Dictionary<String, object> goalKhach = db.LoadRow();
            Goal2.Text = goalKhach["SoBanThuaDoiNha"].ToString();

            string sandauquery = "select TenSan from SanBong";
            db.SetQuery(sandauquery);
            Dictionary<String, object> sandau = db.LoadRow();
            San.Text = sandau["TenSan"].ToString();

            string logo1query = "select Logo from DoiBong where MaDoi = 1;";
            db.SetQuery(logo1query);
            Dictionary<String, object> logo1 = db.LoadRow();

            string logo2query = "select Logo from DoiBong where MaDoi = 2;";
            db.SetQuery(logo2query);
            Dictionary<String, object> logo2 = db.LoadRow();
        }

    
    }
}
