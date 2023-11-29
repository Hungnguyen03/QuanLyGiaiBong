using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class AddTranDau : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        private DataTable dsDoi;
        private DataTable madoikhach;
		private DataTable madoinha;
		string TenDoiNha, TenDoiKhach;
        string MaDN, MaDK;
        public AddTranDau()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
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
			
			if (cmbDoiNha.SelectedItem != null)
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
				TenDoiNha = cmbDoiNha.SelectedItem.ToString();
			}		
			madoikhach = dtBase.DocBang("select MaDoi from DoiBong where TenDoi like  N'" + TenDoiNha + "'");
			foreach (DataRow row in madoikhach.Rows)
			{
				MaDN = row["MaDoi"].ToString();
			}

		}

        private void cmbDoiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
			
			if (cmbDoiKhach.SelectedItem != null)
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
				TenDoiKhach = cmbDoiKhach.SelectedItem.ToString();
			}
 
			
			madoinha = dtBase.DocBang("select MaDoi from DoiBong where TenDoi like N'" + TenDoiKhach + "'");
			foreach (DataRow row in madoinha.Rows)
			{
				MaDK = row["MaDoi"].ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbLuot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbVong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbLuot.Text.Trim() == "" || tbVong.Text == "" ||
                cmbDoiKhach.SelectedIndex == 0 || cmbDoiNha.SelectedIndex ==0 )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trận đấu!");
            }
            else
            {
                string sql = "insert into TranDau(LuotDau,VongDau,MaDoiNha,MaDoiKhach,SoBanThangDoiNha,SoBanThuaDoiNha," +
                "SoTheVangDoiNha,SoTheDoDoiNha,SoTheVangDoiKhach,SoTheDoDoiKhach,GhiChu) values " +
                "" + "('" + int.Parse(tbLuot.Text) + "','" + int.Parse(tbVong.Text) + "','" + int.Parse(MaDN) + "','" + int.Parse(MaDK) + "','0','0','0','0','0','0',N'" + tbGhiChu.Text + "')";
                dtBase.CapNhatDuLieu(sql);
                MessageBox.Show("Đã Thêm Trận Đấu");
                this.Close();   
            }

        }
    }
}
