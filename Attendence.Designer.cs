namespace Payroll_Management
{
    partial class Attendence
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fn_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.absent_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pre_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Ex_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.edit_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.login_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.up_delete = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fn_txt
            // 
            this.fn_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fn_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.fn_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.fn_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fn_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fn_txt.Enabled = false;
            this.fn_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fn_txt.HintForeColor = System.Drawing.Color.Empty;
            this.fn_txt.HintText = "";
            this.fn_txt.isPassword = false;
            this.fn_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.fn_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.fn_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.fn_txt.LineThickness = 2;
            this.fn_txt.Location = new System.Drawing.Point(174, 89);
            this.fn_txt.Margin = new System.Windows.Forms.Padding(5);
            this.fn_txt.MaxLength = 32767;
            this.fn_txt.Name = "fn_txt";
            this.fn_txt.Size = new System.Drawing.Size(154, 41);
            this.fn_txt.TabIndex = 56;
            this.fn_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Consolas", 13F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(167, 62);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(120, 22);
            this.bunifuCustomLabel1.TabIndex = 54;
            this.bunifuCustomLabel1.Text = "Full Name :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Consolas", 13F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(54, 62);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(50, 22);
            this.bunifuCustomLabel3.TabIndex = 53;
            this.bunifuCustomLabel3.Text = "ID :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 27);
            this.comboBox1.TabIndex = 77;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Consolas", 13F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(345, 62);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(90, 22);
            this.bunifuCustomLabel2.TabIndex = 54;
            this.bunifuCustomLabel2.Text = "Absent :";
            // 
            // absent_txt
            // 
            this.absent_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.absent_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.absent_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.absent_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.absent_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.absent_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absent_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.absent_txt.HintForeColor = System.Drawing.Color.Empty;
            this.absent_txt.HintText = "";
            this.absent_txt.isPassword = false;
            this.absent_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.absent_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.absent_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.absent_txt.LineThickness = 2;
            this.absent_txt.Location = new System.Drawing.Point(352, 89);
            this.absent_txt.Margin = new System.Windows.Forms.Padding(5);
            this.absent_txt.MaxLength = 32767;
            this.absent_txt.Name = "absent_txt";
            this.absent_txt.Size = new System.Drawing.Size(159, 41);
            this.absent_txt.TabIndex = 56;
            this.absent_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Consolas", 13F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(519, 62);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(100, 22);
            this.bunifuCustomLabel4.TabIndex = 54;
            this.bunifuCustomLabel4.Text = "Present :";
            // 
            // pre_txt
            // 
            this.pre_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pre_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pre_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pre_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pre_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pre_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pre_txt.HintForeColor = System.Drawing.Color.Empty;
            this.pre_txt.HintText = "";
            this.pre_txt.isPassword = false;
            this.pre_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.pre_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.pre_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pre_txt.LineThickness = 2;
            this.pre_txt.Location = new System.Drawing.Point(526, 89);
            this.pre_txt.Margin = new System.Windows.Forms.Padding(5);
            this.pre_txt.MaxLength = 32767;
            this.pre_txt.Name = "pre_txt";
            this.pre_txt.Size = new System.Drawing.Size(135, 41);
            this.pre_txt.TabIndex = 56;
            this.pre_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Consolas", 13F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(683, 62);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(100, 22);
            this.bunifuCustomLabel5.TabIndex = 54;
            this.bunifuCustomLabel5.Text = "Excused :";
            // 
            // Ex_txt
            // 
            this.Ex_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ex_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Ex_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Ex_txt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Ex_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ex_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ex_txt.HintForeColor = System.Drawing.Color.Empty;
            this.Ex_txt.HintText = "";
            this.Ex_txt.isPassword = false;
            this.Ex_txt.LineFocusedColor = System.Drawing.Color.Blue;
            this.Ex_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.Ex_txt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Ex_txt.LineThickness = 2;
            this.Ex_txt.Location = new System.Drawing.Point(690, 89);
            this.Ex_txt.Margin = new System.Windows.Forms.Padding(5);
            this.Ex_txt.MaxLength = 32767;
            this.Ex_txt.Name = "Ex_txt";
            this.Ex_txt.Size = new System.Drawing.Size(135, 41);
            this.Ex_txt.TabIndex = 56;
            this.Ex_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Consolas", 13F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(846, 62);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(90, 22);
            this.bunifuCustomLabel6.TabIndex = 78;
            this.bunifuCustomLabel6.Text = "Period :";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Delete";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 6;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(630, 170);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(105, 47);
            this.bunifuThinButton21.TabIndex = 82;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // edit_btn
            // 
            this.edit_btn.ActiveBorderThickness = 1;
            this.edit_btn.ActiveCornerRadius = 20;
            this.edit_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.edit_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.edit_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.edit_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.edit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.edit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_btn.BackgroundImage")));
            this.edit_btn.ButtonText = "Edit";
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.IdleBorderThickness = 1;
            this.edit_btn.IdleCornerRadius = 6;
            this.edit_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.edit_btn.IdleForecolor = System.Drawing.Color.White;
            this.edit_btn.IdleLineColor = System.Drawing.Color.Gray;
            this.edit_btn.Location = new System.Drawing.Point(489, 170);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(118, 47);
            this.edit_btn.TabIndex = 81;
            this.edit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click_1);
            // 
            // login_btn
            // 
            this.login_btn.ActiveBorderThickness = 1;
            this.login_btn.ActiveCornerRadius = 20;
            this.login_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.login_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.login_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.login_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.login_btn.BackColor = System.Drawing.SystemColors.Control;
            this.login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_btn.BackgroundImage")));
            this.login_btn.ButtonText = "Save";
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.IdleBorderThickness = 1;
            this.login_btn.IdleCornerRadius = 6;
            this.login_btn.IdleFillColor = System.Drawing.Color.Green;
            this.login_btn.IdleForecolor = System.Drawing.Color.White;
            this.login_btn.IdleLineColor = System.Drawing.Color.Gray;
            this.login_btn.Location = new System.Drawing.Point(322, 170);
            this.login_btn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(133, 47);
            this.login_btn.TabIndex = 80;
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click_1);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 256);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1100, 291);
            this.guna2DataGridView1.TabIndex = 83;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_time
            // 
            this.lb_time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_time.AutoSize = true;
            this.lb_time.BackColor = System.Drawing.Color.Transparent;
            this.lb_time.Font = new System.Drawing.Font("Consolas", 8F);
            this.lb_time.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_time.Location = new System.Drawing.Point(858, 117);
            this.lb_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(55, 13);
            this.lb_time.TabIndex = 78;
            this.lb_time.Text = "Period :";
            this.lb_time.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
            // 
            // up_delete
            // 
            this.up_delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.up_delete.AutoSize = true;
            this.up_delete.BackColor = System.Drawing.Color.Transparent;
            this.up_delete.Font = new System.Drawing.Font("Consolas", 8F);
            this.up_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.up_delete.Location = new System.Drawing.Point(861, 117);
            this.up_delete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.up_delete.Name = "up_delete";
            this.up_delete.Size = new System.Drawing.Size(55, 13);
            this.up_delete.TabIndex = 84;
            this.up_delete.Text = "Period :";
            this.up_delete.Click += new System.EventHandler(this.bunifuCustomLabel7_Click_1);
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(389, 5);
            this.bunifuCustomLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(143, 33);
            this.bunifuCustomLabel14.TabIndex = 103;
            this.bunifuCustomLabel14.Text = "Attendence";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.up_delete);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.bunifuThinButton21);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.edit_btn);
            this.groupBox1.Controls.Add(this.fn_txt);
            this.groupBox1.Controls.Add(this.login_btn);
            this.groupBox1.Controls.Add(this.absent_txt);
            this.groupBox1.Controls.Add(this.lb_time);
            this.groupBox1.Controls.Add(this.pre_txt);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.Controls.Add(this.Ex_txt);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 250);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attedence";
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.guna2DataGridView1);
            this.Name = "Attendence";
            this.Size = new System.Drawing.Size(1100, 547);
            this.Load += new System.EventHandler(this.Attendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox fn_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox absent_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pre_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Ex_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 edit_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 login_btn;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_time;
        private Bunifu.Framework.UI.BunifuCustomLabel up_delete;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
