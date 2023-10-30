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
    public partial class VPL : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public VPL()
        {
            InitializeComponent();
        }

        private void VPL_Load(object sender, EventArgs e)
        {
            DataTable dtVua = dtBase.DocBang("SELECT TOP 3 Anh, TenCT, ViTri,SoBanThang FROM CauThu ORDER BY SoBanThang DESC");
            dgvVPL.DataSource = dtVua;
            
            dtVua.Dispose();//Giải phóng bộ nhớ cho DataTable
        }

        private void dgvVPL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
