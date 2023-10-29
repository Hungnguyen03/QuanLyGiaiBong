namespace QuanLyGiaiBong
{
    partial class AddClub
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
            this.txtAddTenDoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddMaSan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddHLV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddTinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_choosePic = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogoLink = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddTenDoi
            // 
            this.txtAddTenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTenDoi.Location = new System.Drawing.Point(219, 145);
            this.txtAddTenDoi.Name = "txtAddTenDoi";
            this.txtAddTenDoi.Size = new System.Drawing.Size(215, 34);
            this.txtAddTenDoi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin đội bóng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAddMaSan
            // 
            this.txtAddMaSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMaSan.Location = new System.Drawing.Point(219, 188);
            this.txtAddMaSan.Name = "txtAddMaSan";
            this.txtAddMaSan.Size = new System.Drawing.Size(215, 34);
            this.txtAddMaSan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sân";
            // 
            // txtAddHLV
            // 
            this.txtAddHLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddHLV.Location = new System.Drawing.Point(219, 231);
            this.txtAddHLV.Name = "txtAddHLV";
            this.txtAddHLV.Size = new System.Drawing.Size(215, 34);
            this.txtAddHLV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Huấn luyện viên";
            // 
            // txtAddTinh
            // 
            this.txtAddTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTinh.Location = new System.Drawing.Point(219, 279);
            this.txtAddTinh.Name = "txtAddTinh";
            this.txtAddTinh.Size = new System.Drawing.Size(215, 34);
            this.txtAddTinh.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã tỉnh";
            // 
            // btn_choosePic
            // 
            this.btn_choosePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choosePic.Location = new System.Drawing.Point(847, 152);
            this.btn_choosePic.Name = "btn_choosePic";
            this.btn_choosePic.Size = new System.Drawing.Size(140, 40);
            this.btn_choosePic.TabIndex = 2;
            this.btn_choosePic.Text = "Chọn file ảnh";
            this.btn_choosePic.UseVisualStyleBackColor = true;
            this.btn_choosePic.Click += new System.EventHandler(this.btn_choosePic_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(847, 207);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(140, 40);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Thêm DB";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(847, 262);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(140, 40);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Xóa";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Logo";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // logoPic
            // 
            this.logoPic.Location = new System.Drawing.Point(591, 146);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(202, 187);
            this.logoPic.TabIndex = 3;
            this.logoPic.TabStop = false;
            this.logoPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên đội bóng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtLogoLink
            // 
            this.txtLogoLink.Location = new System.Drawing.Point(591, 118);
            this.txtLogoLink.Name = "txtLogoLink";
            this.txtLogoLink.Size = new System.Drawing.Size(202, 22);
            this.txtLogoLink.TabIndex = 4;
            this.txtLogoLink.Visible = false;
            // 
            // AddClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 359);
            this.Controls.Add(this.txtLogoLink);
            this.Controls.Add(this.logoPic);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_choosePic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddTinh);
            this.Controls.Add(this.txtAddHLV);
            this.Controls.Add(this.txtAddMaSan);
            this.Controls.Add(this.txtAddTenDoi);
            this.Name = "AddClub";
            this.Text = "AddClub";
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddTenDoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddMaSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddHLV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_choosePic;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogoLink;
    }
}