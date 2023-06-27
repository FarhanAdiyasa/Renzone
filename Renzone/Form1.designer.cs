using Renzone;

namespace KategoriGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtID = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtNama = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mskategorigameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            /*this.renzoneDataSet = new KategoriGame.();*/
            this.gunaLineTextBox3 = new Guna.UI.WinForms.GunaLineTextBox();
            /*this.ms_kategorigameTableAdapter = new KategoriGame.RenzoneDataSetTableAdapters.ms_kategorigameTableAdapter();*/
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton7 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton9 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton10 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton11 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton12 = new Guna.UI.WinForms.GunaButton();
            this.id_kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskategorigameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renzoneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Renzone.Properties.Resources.id;
            this.gunaPictureBox1.Location = new System.Drawing.Point(456, 163);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(40, 37);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::Renzone.Properties.Resources.Icon;
            this.gunaPictureBox2.Location = new System.Drawing.Point(456, 269);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(40, 37);
            this.gunaPictureBox2.TabIndex = 2;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(512, 163);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(240, 19);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "ID Kategori Game    :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(512, 269);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(240, 19);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Nama Kategori Game  :";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.LineColor = System.Drawing.Color.Gainsboro;
            this.txtID.Location = new System.Drawing.Point(795, 163);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(195, 34);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.White;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.FocusedLineColor = System.Drawing.Color.Black;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.LineColor = System.Drawing.Color.Gainsboro;
            this.txtNama.Location = new System.Drawing.Point(795, 272);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(195, 34);
            this.txtNama.TabIndex = 7;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Navy;
            this.gunaButton1.Image = global::Renzone.Properties.Resources.save;
            this.gunaButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton1.Location = new System.Drawing.Point(513, 375);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(143, 49);
            this.gunaButton1.TabIndex = 8;
            this.gunaButton1.Text = "Simpan";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.White;
            this.gunaButton2.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.DarkBlue;
            this.gunaButton2.Image = global::Renzone.Properties.Resources.Vector__1_;
            this.gunaButton2.ImageSize = new System.Drawing.Size(27, 27);
            this.gunaButton2.Location = new System.Drawing.Point(744, 375);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(151, 49);
            this.gunaButton2.TabIndex = 9;
            this.gunaButton2.Text = "Batal";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_kategori,
            this.nama_kategori,
            this.Update});
            this.bunifuCustomDataGrid1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomDataGrid1.DataSource = this.mskategorigameBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.PaleTurquoise;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(425, 589);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 62;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 28;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(936, 240);
            this.bunifuCustomDataGrid1.TabIndex = 10;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // mskategorigameBindingSource
            // 
            this.mskategorigameBindingSource.DataMember = "ms_kategorigame";
            this.mskategorigameBindingSource.DataSource = this.renzoneDataSet;
            // 
            // renzoneDataSet
            // 
            this.renzoneDataSet.DataSetName = "RenzoneDataSet";
            this.renzoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaLineTextBox3
            // 
            this.gunaLineTextBox3.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox3.Location = new System.Drawing.Point(768, 536);
            this.gunaLineTextBox3.Name = "gunaLineTextBox3";
            this.gunaLineTextBox3.PasswordChar = '\0';
            this.gunaLineTextBox3.SelectedText = "";
            this.gunaLineTextBox3.Size = new System.Drawing.Size(299, 47);
            this.gunaLineTextBox3.TabIndex = 12;
            this.gunaLineTextBox3.TextChanged += new System.EventHandler(this.gunaLineTextBox3_TextChanged);
            // 
            // ms_kategorigameTableAdapter
            // 
            this.ms_kategorigameTableAdapter.ClearBeforeFill = true;
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.Goldenrod;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = global::Renzone.Properties.Resources.dashboard;
            this.gunaButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton4.Location = new System.Drawing.Point(12, 205);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 30;
            this.gunaButton4.Size = new System.Drawing.Size(316, 52);
            this.gunaButton4.TabIndex = 13;
            this.gunaButton4.Text = "Dashboard";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.Goldenrod;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = global::Renzone.Properties.Resources.ps;
            this.gunaButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton5.Location = new System.Drawing.Point(12, 282);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 30;
            this.gunaButton5.Size = new System.Drawing.Size(316, 53);
            this.gunaButton5.TabIndex = 14;
            this.gunaButton5.Text = "PlayStation";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BaseColor = System.Drawing.Color.Goldenrod;
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton6.ForeColor = System.Drawing.Color.White;
            this.gunaButton6.Image = global::Renzone.Properties.Resources.game;
            this.gunaButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton6.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton6.Location = new System.Drawing.Point(12, 360);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Radius = 30;
            this.gunaButton6.Size = new System.Drawing.Size(316, 51);
            this.gunaButton6.TabIndex = 15;
            this.gunaButton6.Text = "Game";
            this.gunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton7
            // 
            this.gunaButton7.AnimationHoverSpeed = 0.07F;
            this.gunaButton7.AnimationSpeed = 0.03F;
            this.gunaButton7.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton7.BaseColor = System.Drawing.Color.Goldenrod;
            this.gunaButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton7.ForeColor = System.Drawing.Color.White;
            this.gunaButton7.Image = global::Renzone.Properties.Resources.kategori;
            this.gunaButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton7.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton7.Location = new System.Drawing.Point(12, 439);
            this.gunaButton7.Name = "gunaButton7";
            this.gunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton7.OnHoverImage = null;
            this.gunaButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton7.Radius = 30;
            this.gunaButton7.Size = new System.Drawing.Size(316, 51);
            this.gunaButton7.TabIndex = 16;
            this.gunaButton7.Text = "Kategori Game";
            this.gunaButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton8
            // 
            this.gunaButton8.AnimationHoverSpeed = 0.07F;
            this.gunaButton8.AnimationSpeed = 0.03F;
            this.gunaButton8.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton8.BaseColor = System.Drawing.Color.Goldenrod;
            this.gunaButton8.BorderColor = System.Drawing.Color.Black;
            this.gunaButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton8.ForeColor = System.Drawing.Color.White;
            this.gunaButton8.Image = global::KategoriGame.Properties.Resources.meja;
            this.gunaButton8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton8.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton8.Location = new System.Drawing.Point(12, 519);
            this.gunaButton8.Name = "gunaButton8";
            this.gunaButton8.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton8.OnHoverImage = null;
            this.gunaButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton8.Radius = 30;
            this.gunaButton8.Size = new System.Drawing.Size(316, 52);
            this.gunaButton8.TabIndex = 17;
            this.gunaButton8.Text = "Meja";
            this.gunaButton8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton9
            // 
            this.gunaButton9.AnimationHoverSpeed = 0.07F;
            this.gunaButton9.AnimationSpeed = 0.03F;
            this.gunaButton9.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton9.BaseColor = System.Drawing.Color.Goldenrod;
            this.gunaButton9.BorderColor = System.Drawing.Color.Black;
            this.gunaButton9.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton9.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton9.ForeColor = System.Drawing.Color.White;
            this.gunaButton9.Image = global::KategoriGame.Properties.Resources.promo;
            this.gunaButton9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton9.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton9.Location = new System.Drawing.Point(12, 602);
            this.gunaButton9.Name = "gunaButton9";
            this.gunaButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton9.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton9.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton9.OnHoverImage = null;
            this.gunaButton9.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton9.Radius = 30;
            this.gunaButton9.Size = new System.Drawing.Size(316, 54);
            this.gunaButton9.TabIndex = 18;
            this.gunaButton9.Text = "Promo";
            this.gunaButton9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton10
            // 
            this.gunaButton10.AnimationHoverSpeed = 0.07F;
            this.gunaButton10.AnimationSpeed = 0.03F;
            this.gunaButton10.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton10.BaseColor = System.Drawing.Color.Goldenrod;
            this.gunaButton10.BorderColor = System.Drawing.Color.White;
            this.gunaButton10.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton10.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton10.ForeColor = System.Drawing.Color.White;
            this.gunaButton10.Image = global::KategoriGame.Properties.Resources.paket2;
            this.gunaButton10.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton10.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton10.Location = new System.Drawing.Point(12, 686);
            this.gunaButton10.Name = "gunaButton10";
            this.gunaButton10.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton10.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton10.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton10.OnHoverImage = null;
            this.gunaButton10.OnPressedColor = System.Drawing.Color.White;
            this.gunaButton10.Radius = 30;
            this.gunaButton10.Size = new System.Drawing.Size(316, 51);
            this.gunaButton10.TabIndex = 19;
            this.gunaButton10.Text = "Paket";
            this.gunaButton10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton11
            // 
            this.gunaButton11.AnimationHoverSpeed = 0.07F;
            this.gunaButton11.AnimationSpeed = 0.03F;
            this.gunaButton11.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton11.BaseColor = System.Drawing.Color.Goldenrod;
            this.gunaButton11.BorderColor = System.Drawing.Color.Black;
            this.gunaButton11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton11.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton11.ForeColor = System.Drawing.Color.White;
            this.gunaButton11.Image = global::KategoriGame.Properties.Resources.aket;
            this.gunaButton11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton11.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton11.Location = new System.Drawing.Point(12, 770);
            this.gunaButton11.Name = "gunaButton11";
            this.gunaButton11.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton11.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton11.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton11.OnHoverImage = null;
            this.gunaButton11.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton11.Radius = 30;
            this.gunaButton11.Size = new System.Drawing.Size(316, 47);
            this.gunaButton11.TabIndex = 20;
            this.gunaButton11.Text = "Aksesoris";
            this.gunaButton11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton12
            // 
            this.gunaButton12.AnimationHoverSpeed = 0.07F;
            this.gunaButton12.AnimationSpeed = 0.03F;
            this.gunaButton12.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton12.BaseColor = System.Drawing.Color.Goldenrod;
            this.gunaButton12.BorderColor = System.Drawing.Color.Black;
            this.gunaButton12.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton12.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton12.ForeColor = System.Drawing.Color.White;
            this.gunaButton12.Image = global::KategoriGame.Properties.Resources.keluar;
            this.gunaButton12.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton12.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton12.Location = new System.Drawing.Point(12, 845);
            this.gunaButton12.Name = "gunaButton12";
            this.gunaButton12.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton12.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton12.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton12.OnHoverImage = null;
            this.gunaButton12.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton12.Radius = 30;
            this.gunaButton12.Size = new System.Drawing.Size(316, 47);
            this.gunaButton12.TabIndex = 21;
            this.gunaButton12.Text = "Leave";
            this.gunaButton12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id_kategori
            // 
            this.id_kategori.DataPropertyName = "id_kategori";
            this.id_kategori.HeaderText = "id_kategori";
            this.id_kategori.MinimumWidth = 8;
            this.id_kategori.Name = "id_kategori";
            this.id_kategori.ReadOnly = true;
            this.id_kategori.Width = 270;
            // 
            // nama_kategori
            // 
            this.nama_kategori.DataPropertyName = "nama_kategori";
            this.nama_kategori.HeaderText = "nama_kategori";
            this.nama_kategori.MinimumWidth = 8;
            this.nama_kategori.Name = "nama_kategori";
            this.nama_kategori.ReadOnly = true;
            this.nama_kategori.Width = 270;
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Uodate";
            this.Update.HeaderText = "Update";
            this.Update.Image = global::KategoriGame.Properties.Resources.pencil;
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Width = 270;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KategoriGame.Properties.Resources.fixx;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.gunaButton12);
            this.Controls.Add(this.gunaButton11);
            this.Controls.Add(this.gunaButton10);
            this.Controls.Add(this.gunaButton9);
            this.Controls.Add(this.gunaButton8);
            this.Controls.Add(this.gunaButton7);
            this.Controls.Add(this.gunaButton6);
            this.Controls.Add(this.gunaButton5);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.gunaLineTextBox3);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskategorigameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renzoneDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txtID;
        private Guna.UI.WinForms.GunaLineTextBox txtNama;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox3;
        private RenzonDataSet1 renzoneDataSet;
        private System.Windows.Forms.BindingSource mskategorigameBindingSource;
        /*private Renzon.ms_kategorigameTableAdapter ms_kategorigameTableAdapter;*/
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton gunaButton7;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaButton gunaButton9;
        private Guna.UI.WinForms.GunaButton gunaButton10;
        private Guna.UI.WinForms.GunaButton gunaButton11;
        private Guna.UI.WinForms.GunaButton gunaButton12;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kategori;
       /* private System.Windows.Forms.DataGridViewImageColumn Upda;*/
    }
}

