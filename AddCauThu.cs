using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class AddCauThu : Form
    {
        ProcessDataBase dtBase = new ProcessDataBase();
        private DataTable dsDoi;
        public AddCauThu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AddCauThu_Load(object sender, EventArgs e)
        {
            dsDoi = dtBase.DocBang("select TenDoi from DoiBong");
            if (dsDoi != null && dsDoi.Rows.Count > 0)
            {
                foreach (DataRow row in dsDoi.Rows)
                {
                    string tenDoi = row["TenDoi"].ToString();
                    cmbDoi.Items.Add(tenDoi);
                }
            }
            dsDoi.Dispose();
            setColor();
        }

        private void setColor()
        {
            btnXoa.IdleFillColor = Color.FromArgb(249, 148, 23);
            btnThem.IdleFillColor = Color.FromArgb(249, 148, 23);
            btnTai.IdleFillColor = Color.FromArgb(249, 148, 23);
            btnXoa.IdleBorderColor = Color.FromArgb(249, 148, 23);
            btnThem.IdleBorderColor = Color.FromArgb(249, 148, 23);
            btnTai.IdleBorderColor = Color.FromArgb(249, 148, 23);
            pTitlebar.BackColor = Color.FromArgb(54, 48, 98);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbTen.Text = "";
            tbSoAo.Text = "";
            tbQuocTich.Text = "";
            cmbViTri.SelectedIndex = -1;
            cmbDoi.SelectedIndex = -1;
            dtpNgaySinh.Value = dtpNgaySinh.MinDate;
            pbAnh.Image = null;
        }

        private void btnTai_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    imgName.Text = Path.GetFileName(imagePath);
                    pbAnh.Image = Image.FromFile(imagePath);
                }
            }
        }
        private void check_QT()
        {
            DataTable get_qt = dtBase.DocBang("select maquoctich from quoctich where tenquoctich like N'" + tbQuocTich.Text + "'");
            if (get_qt.Rows.Count == 0)
            {
                dtBase.CapNhatDuLieu("insert into QuocTich(TenquocTich) values(N'" + tbQuocTich.Text + "')");
            }
            else
            {

            }
            get_qt.Dispose();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbDoi.SelectedIndex == -1 || tbTen.Text.Trim() == "" ||
                cmbViTri.SelectedIndex == -1 || tbSoAo.Text.Trim() == "" ||
                tbQuocTich.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cầu thủ!");
            }
            else
            {
                check_QT();
                string Get_MD = cmbDoi.SelectedItem.ToString();
                DataTable get_md = dtBase.DocBang("select MaDoi from DoiBong where TenDoi like CONCAT('%',N'"+Get_MD + "')");
                int maDoi = int.Parse(get_md.Rows[0]["MaDoi"].ToString());
                DataTable get_qt = dtBase.DocBang("select maquoctich from quoctich where tenquoctich like N'" + tbQuocTich.Text + "'");
                int MQT = int.Parse(get_qt.Rows[0]["maquoctich"].ToString());

                dtBase.CapNhatDuLieu("insert into Cauthu(MaDoi,TenCT,MaViTri,NgaySinh,SoAo,MaQuocTich,Anh) " +
                "values(" + maDoi + ",N'" + tbTen.Text + "'," +
                "" + (cmbViTri.SelectedIndex + 1) + ",'" + dtpNgaySinh.Text + "'," +
                "" + tbSoAo.Text + "," + MQT + ",'" + imgName.Text + "')");
                MessageBox.Show("Đã thêm cầu thủ!");

                dtBase.CapNhatDuLieu("update DoiBong set SoLuongCT = ISNULL(SoLuongCT,0) + 1 where DoiBong.MaDoi = '" + (cmbDoi.SelectedIndex + 1) + "'");

            }
        }
        private void cmbDoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pTitlebar_Click(object sender, EventArgs e)
        {

        }
    }
}
