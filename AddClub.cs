using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiBong
{
    public partial class AddClub : Form
    {
        ProcessDataBase conn = new ProcessDataBase();
        public AddClub()
        {
            InitializeComponent();
        }
        private void EmptyText()
        {
            txtAddTenSan.Text = "";
            txtAddTenDoi.Text = "";
            txtAddHLV.Text = "";
            txtAddTinh.Text = "";
            
        }
        private void check_MS()
        {
            DataTable get_ms = conn.DocBang("select masan from SanBong where tensan like concat('%',N'" + txtAddTenSan.Text + "')");
            if(get_ms.Rows.Count == 0)
            {
                conn.CapNhatDuLieu("insert into sanbong(tensan) values(N'" + txtAddTenSan.Text + "')");
            }
            else
            {

            }
            get_ms.Dispose();
        }
        private void check_MT()
        {
            DataTable get_mt = conn.DocBang("select matinh from tinh where tentinh like N'"+txtAddTinh.Text+"'");
            int check_mt = int.Parse(get_mt.Rows[0]["matinh"].ToString());
            if (get_mt.Rows.Count == 0)
            {
                conn.CapNhatDuLieu("insert into Tinh(tentinh) values(N'" + txtAddTinh.Text + "')");
            }
            else 
            { 
            
            }
            get_mt.Dispose();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtAddTenSan.Text.Trim() == "" || txtAddTenDoi.Text == "" ||
                txtAddHLV.Text == "" || txtAddTinh.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin đội bóng!");
                txtAddTenDoi.Focus();
            }
            else
            {
                check_MS();
                check_MT();
                DataTable get_ms = conn.DocBang("select masan from SanBong where tensan like concat('%',N'" + txtAddTenSan.Text + "')");
                int MS = int.Parse(get_ms.Rows[0]["masan"].ToString());
                DataTable get_mt = conn.DocBang("select matinh from tinh where tentinh like N'" + txtAddTinh.Text + "'");
                int MT = int.Parse(get_mt.Rows[0]["matinh"].ToString());

                DataTable dt = new DataTable();
                conn.CapNhatDuLieu("insert into DoiBong(TenDoi,MaSan,HLV,MaTinh,Logo) " +
                    "values(N'" + txtAddTenDoi.Text + "'," +
                    "" + MS + "," +
                    "N'" + txtAddHLV.Text + "'," +
                    "" + MT + "," +
                    "'" + txtLogoLink.Text + "')");

                MessageBox.Show("New club added!");
                get_ms.Dispose();
                get_mt.Dispose();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            EmptyText();
        }

        private void btn_choosePic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    txtLogoLink.Text = imagePath;
                    logoPic.Image = Image.FromFile(imagePath);
                }
            }
        }
    }
}
