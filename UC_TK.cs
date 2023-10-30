using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class UC_TK : UserControl
    {
        public UC_TK()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void UC_TK_Load(object sender, EventArgs e)
        {
            Database dtBase = new Database();
            DataTable dtGoal1 = dtBase.DocBang("select TenCT, ThoiGian from CauThu inner join TranDau_BanThang on CauThu.MaCT = TranDau_BanThang.MaCauThu where MaDoi = 1");
            dgvGoal1.DataSource = dtGoal1;
            dgvGoal1.Columns[0].HeaderText = "Cầu Thủ";
            dgvGoal1.Columns[1].HeaderText = "Thời Gian";
            dtGoal1.Dispose();

            DataTable dtGoal2 = dtBase.DocBang("select TenCT, ThoiGian from CauThu inner join TranDau_BanThang on CauThu.MaCT = TranDau_BanThang.MaCauThu where MaDoi = 2");
            dgvGoal2.DataSource = dtGoal2;
            dgvGoal2.Columns[0].HeaderText = "Cầu Thủ";
            dgvGoal2.Columns[1].HeaderText = "Thời Gian";
            dtGoal2.Dispose();

            DataTable dtYellow1 = dtBase.DocBang("select TenCT, ThoiGian from CauThu inner join TranDau_The on CauThu.MaCT = TranDau_The.MaCauThu where LoaiThe = N'Thẻ Vàng' and MaDoi = 1");
            dgvYellow1.DataSource = dtYellow1;
            dgvYellow1.Columns[0].HeaderText = "Cầu Thủ";
            dgvYellow1.Columns[1].HeaderText = "Thời Gian";
            dtYellow1.Dispose();

            DataTable dtYellow2 = dtBase.DocBang("select TenCT, ThoiGian from CauThu inner join TranDau_The on CauThu.MaCT = TranDau_The.MaCauThu where LoaiThe = N'Thẻ Vàng' and MaDoi = 2");
            dgvYellow2.DataSource = dtYellow2;
            dgvYellow2.Columns[0].HeaderText = "Cầu Thủ";
            dgvYellow2.Columns[1].HeaderText = "Thời Gian";
            dtYellow2.Dispose();

            DataTable dtRed1 = dtBase.DocBang("select TenCT, ThoiGian from CauThu inner join TranDau_The on CauThu.MaCT = TranDau_The.MaCauThu where LoaiThe = N'Thẻ Đỏ' and MaDoi = 1");
            dgvRed1.DataSource = dtRed1;
            dgvRed1.Columns[0].HeaderText = "Cầu Thủ";
            dgvRed1.Columns[1].HeaderText = "Thời Gian";
            dtRed1.Dispose();

            DataTable dtRed2 = dtBase.DocBang("select TenCT, ThoiGian from CauThu inner join TranDau_The on CauThu.MaCT = TranDau_The.MaCauThu where LoaiThe = N'Thẻ Đỏ' and MaDoi = 2");
            dgvRed2.DataSource = dtRed2;
            dgvRed2.Columns[0].HeaderText = "Cầu Thủ";
            dgvRed2.Columns[1].HeaderText = "Thời Gian";
            dtRed2.Dispose();
        }
    }
}
