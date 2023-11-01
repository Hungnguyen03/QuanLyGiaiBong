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
        int maDoiNha, maDoiKhach;
        public UC_DH(int maTD)
        {
            InitializeComponent();
            DataTable ctTranDau = dtBase.DocBang("select MaDoiNha, MaDoiKhach from TranDau where MaTranDau = " + maTD);
            maDoiNha = Convert.ToInt32(ctTranDau.Rows[0]["MaDoiNha"]);
            maDoiKhach = Convert.ToInt32(ctTranDau.Rows[0]["MaDoiNha"]);
        }

        private void UC_DH_Load(object sender, EventArgs e)
        {
            DataTable dtCauThu1 = dtBase.DocBang("select TenCT from CauThu where MaDoi = " + maDoiNha);
            dgvDH1.DataSource = dtCauThu1;
            dgvDH1.Columns[0].HeaderText = "Cầu Thủ";
            dtCauThu1.Dispose();

            DataTable dtCauThu2 = dtBase.DocBang("select TenCT from CauThu where MaDoi = " + maDoiKhach);
            dgvDH2.DataSource = dtCauThu2;
            dgvDH2.Columns[0].HeaderText = "Cầu Thủ";
            dtCauThu2.Dispose();
        }
    }
}
