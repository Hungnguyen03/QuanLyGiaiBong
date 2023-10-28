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
    public partial class DSDB : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public DSDB()
        {
            InitializeComponent();
        }

        private void DSDB_Load(object sender, EventArgs e)
        {
            DataTable dtDoiBong = dtBase.DocBang("select LoGo,Madoi, Tendoi,Diem from DoiBong");
            dgvDSDB.DataSource = dtDoiBong;
            //Định dạng dataGrid
            // dgvDSDB.Columns[0].HeaderText = "Mã Doi Bong";
            //dgvDSDB.Columns[1].HeaderText = "Tên Doi Bong";
            //dgvDSDB.Columns[0].Height = 150;
            //dgvDSDB.Columns[1].Width = 250;
            //dgvDSDB.BackgroundColor = Color.LightBlue;
            dtDoiBong.Dispose();//Giải phóng bộ nhớ cho DataTable
        }
    }
}
