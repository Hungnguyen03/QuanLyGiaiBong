using QuanLyGiaiBong.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class AddTranDau : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        private DataTable dsDoi;

        public AddTranDau()
        {
            InitializeComponent();
        }

        private void AddTranDau_Load(object sender, EventArgs e)
        {
            dsDoi = dtBase.DocBang("select * from DoiBong ");
            if (dsDoi != null && dsDoi.Rows.Count > 0)
            {
                foreach (DataRow row in dsDoi.Rows)
                {
                    string tenDoi = row["TenDoi"].ToString();
                    cmbDoiNha.Items.Add(tenDoi);
                    cmbDoiKhach.Items.Add(tenDoi);
                }
            }
            setColor();
        }

        private void setColor()
        {
            btnThem.IdleFillColor = Color.FromArgb(249, 148, 23);
            btnXoa.IdleFillColor = Color.FromArgb(249, 148, 23);
            btnXoa.IdleBorderColor = Color.FromArgb(249, 148, 23);
            btnThem.IdleBorderColor = Color.FromArgb(249, 148, 23);
            pTitlebar.BackColor = Color.FromArgb(54, 48, 98);
        }

        private void cmbDoiNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDoiNha.SelectedItem != null)
            {
                string selectedTeam = cmbDoiNha.SelectedItem.ToString();
                cmbDoiKhach.Items.Clear();
                foreach (object item in cmbDoiNha.Items)
                {
                    if (item.ToString() != selectedTeam)
                    {
                        cmbDoiKhach.Items.Add(item);
                    }
                }
            }
        }

        private void cmbDoiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if(cmbDoiKhach.SelectedItem != null)
            {
                string selectedTeam = cmbDoiKhach.SelectedItem.ToString();
                cmbDoiNha.Items.Clear();
                foreach (object item in cmbDoiKhach.Items)
                {
                    if (item.ToString() != selectedTeam)
                    {
                        cmbDoiNha.Items.Add(item);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbGhiChu.Text = "";
            tbLuot.Text = "";
            tbVong.Text = "";

            cmbDoiNha.SelectedItem = null;
            cmbDoiKhach.SelectedItem = null;
            cmbDoiNha.Items.Clear();
            cmbDoiKhach.Items.Clear();
            if (dsDoi != null && dsDoi.Rows.Count > 0)
            {
                foreach (DataRow row in dsDoi.Rows)
                {
                    string tenDoi = row["TenDoi"].ToString();
                    cmbDoiNha.Items.Add(tenDoi);
                    cmbDoiKhach.Items.Add(tenDoi);
                }
            }
        }
    }
}
