﻿namespace QuanLyGiaiBong
{
    partial class DSCauThuThiDauForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSCauThuThiDauForm));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvDSCauThu = new Bunifu.UI.WinForms.BunifuDataGridView();
			this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.LuuBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSCauThu)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(340, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(288, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Chọn danh sách cầu thủ thi đấu";
			// 
			// dgvDSCauThu
			// 
			this.dgvDSCauThu.AllowCustomTheming = false;
			this.dgvDSCauThu.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dgvDSCauThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDSCauThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDSCauThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDSCauThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvDSCauThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDSCauThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDSCauThu.ColumnHeadersHeight = 40;
			this.dgvDSCauThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
			this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
			this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
			this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvDSCauThu.CurrentTheme.BackColor = System.Drawing.Color.Orange;
			this.dgvDSCauThu.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
			this.dgvDSCauThu.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Orange;
			this.dgvDSCauThu.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			this.dgvDSCauThu.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvDSCauThu.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
			this.dgvDSCauThu.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dgvDSCauThu.CurrentTheme.Name = null;
			this.dgvDSCauThu.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
			this.dgvDSCauThu.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.dgvDSCauThu.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dgvDSCauThu.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
			this.dgvDSCauThu.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDSCauThu.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDSCauThu.EnableHeadersVisualStyles = false;
			this.dgvDSCauThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
			this.dgvDSCauThu.HeaderBackColor = System.Drawing.Color.Orange;
			this.dgvDSCauThu.HeaderBgColor = System.Drawing.Color.Empty;
			this.dgvDSCauThu.HeaderForeColor = System.Drawing.Color.White;
			this.dgvDSCauThu.Location = new System.Drawing.Point(12, 67);
			this.dgvDSCauThu.Name = "dgvDSCauThu";
			this.dgvDSCauThu.RowHeadersVisible = false;
			this.dgvDSCauThu.RowHeadersWidth = 51;
			this.dgvDSCauThu.RowTemplate.Height = 40;
			this.dgvDSCauThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSCauThu.Size = new System.Drawing.Size(1019, 385);
			this.dgvDSCauThu.TabIndex = 3;
			this.dgvDSCauThu.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
			// 
			// Select
			// 
			this.Select.HeaderText = "Thi đấu";
			this.Select.MinimumWidth = 6;
			this.Select.Name = "Select";
			// 
			// LuuBtn
			// 
			this.LuuBtn.AllowAnimations = true;
			this.LuuBtn.AllowMouseEffects = true;
			this.LuuBtn.AllowToggling = false;
			this.LuuBtn.AnimationSpeed = 200;
			this.LuuBtn.AutoGenerateColors = false;
			this.LuuBtn.AutoRoundBorders = false;
			this.LuuBtn.AutoSizeLeftIcon = true;
			this.LuuBtn.AutoSizeRightIcon = true;
			this.LuuBtn.BackColor = System.Drawing.Color.Transparent;
			this.LuuBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
			this.LuuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuuBtn.BackgroundImage")));
			this.LuuBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.LuuBtn.ButtonText = "Lưu";
			this.LuuBtn.ButtonTextMarginLeft = 0;
			this.LuuBtn.ColorContrastOnClick = 45;
			this.LuuBtn.ColorContrastOnHover = 45;
			this.LuuBtn.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.LuuBtn.CustomizableEdges = borderEdges1;
			this.LuuBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.LuuBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.LuuBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.LuuBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.LuuBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			this.LuuBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.LuuBtn.ForeColor = System.Drawing.Color.White;
			this.LuuBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LuuBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.LuuBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.LuuBtn.IconMarginLeft = 11;
			this.LuuBtn.IconPadding = 10;
			this.LuuBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.LuuBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.LuuBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.LuuBtn.IconSize = 25;
			this.LuuBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
			this.LuuBtn.IdleBorderRadius = 1;
			this.LuuBtn.IdleBorderThickness = 1;
			this.LuuBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
			this.LuuBtn.IdleIconLeftImage = null;
			this.LuuBtn.IdleIconRightImage = null;
			this.LuuBtn.IndicateFocus = false;
			this.LuuBtn.Location = new System.Drawing.Point(829, 470);
			this.LuuBtn.Name = "LuuBtn";
			this.LuuBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.LuuBtn.OnDisabledState.BorderRadius = 1;
			this.LuuBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.LuuBtn.OnDisabledState.BorderThickness = 1;
			this.LuuBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.LuuBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.LuuBtn.OnDisabledState.IconLeftImage = null;
			this.LuuBtn.OnDisabledState.IconRightImage = null;
			this.LuuBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
			this.LuuBtn.onHoverState.BorderRadius = 1;
			this.LuuBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.LuuBtn.onHoverState.BorderThickness = 1;
			this.LuuBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
			this.LuuBtn.onHoverState.ForeColor = System.Drawing.Color.White;
			this.LuuBtn.onHoverState.IconLeftImage = null;
			this.LuuBtn.onHoverState.IconRightImage = null;
			this.LuuBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
			this.LuuBtn.OnIdleState.BorderRadius = 1;
			this.LuuBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.LuuBtn.OnIdleState.BorderThickness = 1;
			this.LuuBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
			this.LuuBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.LuuBtn.OnIdleState.IconLeftImage = null;
			this.LuuBtn.OnIdleState.IconRightImage = null;
			this.LuuBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
			this.LuuBtn.OnPressedState.BorderRadius = 1;
			this.LuuBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			this.LuuBtn.OnPressedState.BorderThickness = 1;
			this.LuuBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
			this.LuuBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.LuuBtn.OnPressedState.IconLeftImage = null;
			this.LuuBtn.OnPressedState.IconRightImage = null;
			this.LuuBtn.Size = new System.Drawing.Size(169, 51);
			this.LuuBtn.TabIndex = 4;
			this.LuuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LuuBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.LuuBtn.TextMarginLeft = 0;
			this.LuuBtn.TextPadding = new System.Windows.Forms.Padding(0);
			this.LuuBtn.UseDefaultRadiusAndThickness = true;
			this.LuuBtn.Click += new System.EventHandler(this.LuuBtn_Click);
			// 
			// DSCauThuThiDauForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1043, 533);
			this.Controls.Add(this.LuuBtn);
			this.Controls.Add(this.dgvDSCauThu);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DSCauThuThiDauForm";
			this.Text = "DSCauThuThiDauForm";
			this.Load += new System.EventHandler(this.DSCauThuThiDauForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSCauThu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDSCauThu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LuuBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
    }
}