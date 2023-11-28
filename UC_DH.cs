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
    public partial class UC_DH : UserControl 
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        int maDoiNha, maDoiKhach, maTD;
        public UC_DH(int maTD)
        {
            InitializeComponent();
            this.maTD = maTD;
            DataTable ctTranDau = dtBase.DocBang("select MaDoiNha, MaDoiKhach from TranDau where MaTranDau = " + maTD);
            maDoiNha = Convert.ToInt32(ctTranDau.Rows[0]["MaDoiNha"]);
            maDoiKhach = Convert.ToInt32(ctTranDau.Rows[0]["MaDoiKhach"]);
        }

        private void dgvDH2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void UC_DH_Load(object sender, EventArgs e)
        {
            DataTable dtCauThu1 = dtBase.DocBang("select TenCT from CauThu JOIN TranDau_CauThu ON MaCT = MaCauThu where TranDau_CauThu.MaDoi = " + maDoiNha + " and MaTranDau = " + maTD);
            dgvDH1.DataSource = dtCauThu1;
            dgvDH1.Columns[0].HeaderText = "Cầu Thủ";
            dtCauThu1.Dispose();

            DataTable dtCauThu2 = dtBase.DocBang("select TenCT from CauThu JOIN TranDau_CauThu ON MaCT = MaCauThu where TranDau_CauThu.MaDoi = " + maDoiKhach + " and MaTranDau = " + maTD);
            dgvDH2.DataSource = dtCauThu2;
            dgvDH2.Columns[0].HeaderText = "Cầu Thủ";
            dtCauThu2.Dispose();
        }
    }
}
