using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLGiaiBongDa.ProcessDatabase;

namespace QLGiaiBongDa
{
    public partial class DSTD : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public DSTD()
        {
            InitializeComponent();
        }

        private void DSTD_Load(object sender, EventArgs e)
        {
            DataTable dtTranDau = dtBase.DocBang("select Luotdau,VongDau,MaDoiNha,MaDoiKhach, SoTheDoDoiNha from TranDau");
            dgvDSTD.DataSource = dtTranDau;
            //Định dạng dataGrid
            //dgvDSTD.Columns[0].HeaderText = "Ten Cau Thu";
            //dgvDSTD.Columns[1].HeaderText = "So Ban Thang";
            //dgvDSTD.Columns[0].Width = 150;
            //dgvDSTD.Columns[1].Width = 250;
            //dgvDSTD.BackgroundColor = Color.LightBlue;
            dtTranDau.Dispose();//Giải phóng bộ nhớ cho DataTable
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
