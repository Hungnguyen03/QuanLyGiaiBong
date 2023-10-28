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
    public partial class DSCT : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        public DSCT()
        {
            InitializeComponent();
        }

        private void DSCT_Load(object sender, EventArgs e)
        {
            DataTable dtCauThu = dtBase.DocBang("select Anh, TenDoi, TenCT, ViTri  from CauThu left join DoiBong on CauThu.MaDoi = DoiBong.MaDoi");
            dgvDSCT.DataSource = dtCauThu;
            //Định dạng dataGrid
            //dgvDSCT.Columns[0].HeaderText = "Ten Cau Thu";
            //dgvDSCT.Columns[1].HeaderText = "So Ban Thang";
            
            //dgvDSCT.Size= new Size(600 ,600);
            //dgvDSCT.BackgroundColor = Color.LightBlue;
            dtCauThu.Dispose();//Giải phóng bộ nhớ cho DataTable
        }

        private void SearchData(string searchValue)
        {
            dgvDSCT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvDSCT.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}
