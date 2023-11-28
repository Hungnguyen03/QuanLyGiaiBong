namespace QuanLyGiaiBong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSCauThuThiDauForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSCauThu = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LuuBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pTitlebar = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCauThu)).BeginInit();
            this.pTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn danh sách cầu thủ thi đấu";
            // 
            // dgvDSCauThu
            // 
            this.dgvDSCauThu.AllowCustomTheming = false;
            this.dgvDSCauThu.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvDSCauThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDSCauThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCauThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSCauThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSCauThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSCauThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDSCauThu.ColumnHeadersHeight = 40;
            this.dgvDSCauThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDSCauThu.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDSCauThu.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDSCauThu.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDSCauThu.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDSCauThu.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDSCauThu.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSCauThu.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvDSCauThu.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDSCauThu.CurrentTheme.Name = null;
            this.dgvDSCauThu.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSCauThu.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDSCauThu.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDSCauThu.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDSCauThu.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSCauThu.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDSCauThu.EnableHeadersVisualStyles = false;
            this.dgvDSCauThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDSCauThu.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDSCauThu.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDSCauThu.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDSCauThu.Location = new System.Drawing.Point(0, 102);
            this.dgvDSCauThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSCauThu.Name = "dgvDSCauThu";
            this.dgvDSCauThu.RowHeadersVisible = false;
            this.dgvDSCauThu.RowHeadersWidth = 51;
            this.dgvDSCauThu.RowTemplate.Height = 40;
            this.dgvDSCauThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCauThu.Size = new System.Drawing.Size(979, 345);
            this.dgvDSCauThu.TabIndex = 3;
            this.dgvDSCauThu.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.LuuBtn.CustomizableEdges = borderEdges3;
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
            this.LuuBtn.Location = new System.Drawing.Point(803, 452);
            this.LuuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.LuuBtn.Size = new System.Drawing.Size(149, 39);
            this.LuuBtn.TabIndex = 4;
            this.LuuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LuuBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LuuBtn.TextMarginLeft = 0;
            this.LuuBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.LuuBtn.UseDefaultRadiusAndThickness = true;
            this.LuuBtn.Click += new System.EventHandler(this.LuuBtn_Click);
            // 
            // pTitlebar
            // 
            this.pTitlebar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.pTitlebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pTitlebar.BackgroundImage")));
            this.pTitlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTitlebar.BorderColor = System.Drawing.Color.Transparent;
            this.pTitlebar.BorderRadius = 3;
            this.pTitlebar.BorderThickness = 1;
            this.pTitlebar.Controls.Add(this.btnClose);
            this.pTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pTitlebar.Margin = new System.Windows.Forms.Padding(4);
            this.pTitlebar.Name = "pTitlebar";
            this.pTitlebar.ShowBorders = true;
            this.pTitlebar.Size = new System.Drawing.Size(982, 60);
            this.pTitlebar.TabIndex = 36;
            this.pTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitlebar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(948, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 46);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DSCauThuThiDauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.pTitlebar);
            this.Controls.Add(this.LuuBtn);
            this.Controls.Add(this.dgvDSCauThu);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DSCauThuThiDauForm";
            this.Text = "DSCauThuThiDauForm";
            this.Load += new System.EventHandler(this.DSCauThuThiDauForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCauThu)).EndInit();
            this.pTitlebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDSCauThu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LuuBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private Bunifu.UI.WinForms.BunifuPanel pTitlebar;
        private System.Windows.Forms.Button btnClose;
    }
}