using System;
using System.Data;
using System.Drawing;
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
                    pbAnh.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
