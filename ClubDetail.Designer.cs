namespace QuanLyGiaiBong
{
    partial class ClubDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMaTenDoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenSan = new System.Windows.Forms.Label();
            this.txtHLV = new System.Windows.Forms.Label();
            this.txtTinh = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.Label();
            this.txtSoBan = new System.Windows.Forms.Label();
            this.DsCauThu = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCauThu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 188);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMaTenDoi
            // 
            this.txtMaTenDoi.AutoSize = true;
            this.txtMaTenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTenDoi.Location = new System.Drawing.Point(408, 22);
            this.txtMaTenDoi.Name = "txtMaTenDoi";
            this.txtMaTenDoi.Size = new System.Drawing.Size(230, 46);
            this.txtMaTenDoi.TabIndex = 1;
            this.txtMaTenDoi.Text = "mã - tên đội";
            this.txtMaTenDoi.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sân";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Huấn luyện viên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên tỉnh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Điểm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số bàn thắng / thua";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTenSan
            // 
            this.txtTenSan.AutoSize = true;
            this.txtTenSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSan.Location = new System.Drawing.Point(559, 77);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(100, 29);
            this.txtTenSan.TabIndex = 1;
            this.txtTenSan.Text = "Ten san";
            // 
            // txtHLV
            // 
            this.txtHLV.AutoSize = true;
            this.txtHLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHLV.Location = new System.Drawing.Point(559, 118);
            this.txtHLV.Name = "txtHLV";
            this.txtHLV.Size = new System.Drawing.Size(58, 29);
            this.txtHLV.TabIndex = 1;
            this.txtHLV.Text = "HVL";
            this.txtHLV.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTinh
            // 
            this.txtTinh.AutoSize = true;
            this.txtTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinh.Location = new System.Drawing.Point(559, 159);
            this.txtTinh.Name = "txtTinh";
            this.txtTinh.Size = new System.Drawing.Size(100, 29);
            this.txtTinh.TabIndex = 1;
            this.txtTinh.Text = "Ten tinh";
            this.txtTinh.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.AutoSize = true;
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(559, 201);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(102, 29);
            this.txtDiem.TabIndex = 1;
            this.txtDiem.Text = "Diem so";
            this.txtDiem.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtSoBan
            // 
            this.txtSoBan.AutoSize = true;
            this.txtSoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBan.Location = new System.Drawing.Point(559, 239);
            this.txtSoBan.Name = "txtSoBan";
            this.txtSoBan.Size = new System.Drawing.Size(58, 29);
            this.txtSoBan.TabIndex = 1;
            this.txtSoBan.Text = "0 / 0";
            this.txtSoBan.Click += new System.EventHandler(this.label11_Click);
            // 
            // DsCauThu
            // 
            this.DsCauThu.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DsCauThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DsCauThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DsCauThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DsCauThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DsCauThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DsCauThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DsCauThu.ColumnHeadersHeight = 40;
            this.DsCauThu.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DsCauThu.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DsCauThu.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DsCauThu.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DsCauThu.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DsCauThu.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DsCauThu.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DsCauThu.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DsCauThu.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DsCauThu.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DsCauThu.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DsCauThu.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DsCauThu.CurrentTheme.Name = null;
            this.DsCauThu.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DsCauThu.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DsCauThu.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DsCauThu.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DsCauThu.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DsCauThu.DefaultCellStyle = dataGridViewCellStyle6;
            this.DsCauThu.EnableHeadersVisualStyles = false;
            this.DsCauThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DsCauThu.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DsCauThu.HeaderBgColor = System.Drawing.Color.Empty;
            this.DsCauThu.HeaderForeColor = System.Drawing.Color.White;
            this.DsCauThu.Location = new System.Drawing.Point(12, 311);
            this.DsCauThu.Name = "DsCauThu";
            this.DsCauThu.RowHeadersVisible = false;
            this.DsCauThu.RowHeadersWidth = 51;
            this.DsCauThu.RowTemplate.Height = 40;
            this.DsCauThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DsCauThu.Size = new System.Drawing.Size(909, 249);
            this.DsCauThu.TabIndex = 2;
            this.DsCauThu.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ClubDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 572);
            this.Controls.Add(this.DsCauThu);
            this.Controls.Add(this.txtSoBan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTinh);
            this.Controls.Add(this.txtHLV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenSan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaTenDoi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClubDetail";
            this.Text = "ClubDetail";
            this.Load += new System.EventHandler(this.ClubDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCauThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtMaTenDoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTenSan;
        private System.Windows.Forms.Label txtHLV;
        private System.Windows.Forms.Label txtTinh;
        private System.Windows.Forms.Label txtDiem;
        private System.Windows.Forms.Label txtSoBan;
        private Bunifu.UI.WinForms.BunifuDataGridView DsCauThu;
    }
}