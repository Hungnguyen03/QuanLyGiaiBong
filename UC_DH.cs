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
        public UC_DH()
        {
            InitializeComponent();
        }

        private void DH1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UC_DH_Load(object sender, EventArgs e)
        {
            Database dtBase = new Database();
            DataTable dtCauThu1 = dtBase.DocBang("select TenCT from CauThu where MaDoi = 1");
            dgvDH1.DataSource = dtCauThu1;
            dgvDH1.Columns[0].HeaderText = "Cầu Thủ";
            dtCauThu1.Dispose();

            DataTable dtCauThu2 = dtBase.DocBang("select TenCT from CauThu where MaDoi = 2");
            dgvDH2.DataSource = dtCauThu2;
            dgvDH2.Columns[0].HeaderText = "Cầu Thủ";
            dtCauThu2.Dispose();
        }
    }
}
