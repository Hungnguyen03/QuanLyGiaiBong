﻿using System;
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
        connectDB conn = new connectDB();
        public AddClub()
        {
            InitializeComponent();
        }
        private void EmptyText()
        {
            txtAddMaSan.Text = "";
            txtAddTenDoi.Text = "";
            txtAddHLV.Text = "";
            txtAddTinh.Text = "";
            
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
            DataTable dt = new DataTable();
            conn.CapNhatDuLieu("insert into DoiBong(TenDoi,MaSan,HLV,MaTinh,Logo) " +
                "values(N'" + txtAddTenDoi.Text + "'," +
                "" + txtAddMaSan.Text + "," +
                "N'" + txtAddHLV.Text + "'," +
                "" + txtAddTinh.Text + "," +
                "'" + txtLogoLink.Text + "')");

            MessageBox.Show("New club added!");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            EmptyText();
        }

        private void btn_choosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog getPic = new OpenFileDialog();
            getPic.Title = "Chọn hình ảnh";
            getPic.InitialDirectory = "C:\\";
            getPic.Filter = "Ảnh (*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";

            if (getPic.ShowDialog() == DialogResult.OK)
            {
                string filePath = getPic.FileName;
                txtLogoLink.Text = filePath;

                Bitmap img = new Bitmap(filePath);

                int width = logoPic.Width;
                int height = logoPic.Height;
                Size newSize = new Size(width, height);
                img.SetResolution(newSize.Width, newSize.Height);

                logoPic.Image = img;
            }
        }
    }
}