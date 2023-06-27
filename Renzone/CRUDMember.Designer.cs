namespace Renzone
{
    partial class CRUDMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDMember));
            this.lbValidasi = new Guna.UI.WinForms.GunaLabel();
            this.tbAlamatM = new Guna.UI.WinForms.GunaTextBox();
            this.tbTelpM = new Guna.UI.WinForms.GunaTextBox();
            this.tbNamaM = new Guna.UI.WinForms.GunaTextBox();
            this.tbIDM = new Guna.UI.WinForms.GunaTextBox();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.tbSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.dgvMember = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_daftar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_anggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.msmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.renzonDataSet1 = new Renzone.RenzonDataSet1();
            this.btnAddCat = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btSave = new Guna.UI.WinForms.GunaButton();
            this.btnMenuAcc = new Guna.UI.WinForms.GunaButton();
            this.btnMenuPS = new Guna.UI.WinForms.GunaButton();
            this.btnMenuMember = new Guna.UI.WinForms.GunaButton();
            this.btnMenuPackage = new Guna.UI.WinForms.GunaButton();
            this.btnMenuTable = new Guna.UI.WinForms.GunaButton();
            this.btnMenuCategory = new Guna.UI.WinForms.GunaButton();
            this.btnMenuGame = new Guna.UI.WinForms.GunaButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaButton();
            this.ms_memberTableAdapter = new Renzone.RenzonDataSet1TableAdapters.ms_memberTableAdapter();
            this.tbTanggalM = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renzonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbValidasi
            // 
            this.lbValidasi.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidasi.ForeColor = System.Drawing.Color.Red;
            this.lbValidasi.Location = new System.Drawing.Point(813, 510);
            this.lbValidasi.Name = "lbValidasi";
            this.lbValidasi.Size = new System.Drawing.Size(260, 21);
            this.lbValidasi.TabIndex = 99;
            this.lbValidasi.Text = "Data tidak boleh kosong !";
            this.lbValidasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbValidasi.Visible = false;
            // 
            // tbAlamatM
            // 
            this.tbAlamatM.BaseColor = System.Drawing.Color.White;
            this.tbAlamatM.BorderColor = System.Drawing.Color.Silver;
            this.tbAlamatM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAlamatM.FocusedBaseColor = System.Drawing.Color.White;
            this.tbAlamatM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbAlamatM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAlamatM.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlamatM.Location = new System.Drawing.Point(721, 251);
            this.tbAlamatM.Name = "tbAlamatM";
            this.tbAlamatM.PasswordChar = '\0';
            this.tbAlamatM.SelectedText = "";
            this.tbAlamatM.Size = new System.Drawing.Size(326, 47);
            this.tbAlamatM.TabIndex = 98;
            // 
            // tbTelpM
            // 
            this.tbTelpM.BaseColor = System.Drawing.Color.White;
            this.tbTelpM.BorderColor = System.Drawing.Color.Silver;
            this.tbTelpM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTelpM.FocusedBaseColor = System.Drawing.Color.White;
            this.tbTelpM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbTelpM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTelpM.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelpM.Location = new System.Drawing.Point(721, 364);
            this.tbTelpM.Name = "tbTelpM";
            this.tbTelpM.PasswordChar = '\0';
            this.tbTelpM.SelectedText = "";
            this.tbTelpM.Size = new System.Drawing.Size(326, 47);
            this.tbTelpM.TabIndex = 97;
            // 
            // tbNamaM
            // 
            this.tbNamaM.BaseColor = System.Drawing.Color.White;
            this.tbNamaM.BorderColor = System.Drawing.Color.Silver;
            this.tbNamaM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNamaM.FocusedBaseColor = System.Drawing.Color.White;
            this.tbNamaM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbNamaM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbNamaM.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaM.Location = new System.Drawing.Point(721, 190);
            this.tbNamaM.Name = "tbNamaM";
            this.tbNamaM.PasswordChar = '\0';
            this.tbNamaM.SelectedText = "";
            this.tbNamaM.Size = new System.Drawing.Size(326, 47);
            this.tbNamaM.TabIndex = 96;
            // 
            // tbIDM
            // 
            this.tbIDM.BaseColor = System.Drawing.Color.White;
            this.tbIDM.BorderColor = System.Drawing.Color.Silver;
            this.tbIDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDM.FocusedBaseColor = System.Drawing.Color.White;
            this.tbIDM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbIDM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbIDM.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDM.Location = new System.Drawing.Point(721, 135);
            this.tbIDM.Name = "tbIDM";
            this.tbIDM.PasswordChar = '\0';
            this.tbIDM.SelectedText = "";
            this.tbIDM.Size = new System.Drawing.Size(326, 47);
            this.tbIDM.TabIndex = 95;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.Enabled = false;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = null;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.ImageSize = new System.Drawing.Size(17, 17);
            this.btnSearch.Location = new System.Drawing.Point(1286, 633);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 15;
            this.btnSearch.Size = new System.Drawing.Size(45, 37);
            this.btnSearch.TabIndex = 94;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.tbSearch.LineSize = 2;
            this.tbSearch.Location = new System.Drawing.Point(964, 633);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(316, 52);
            this.tbSearch.TabIndex = 93;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMember.AutoGenerateColumns = false;
            this.dgvMember.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_member,
            this.nama_member,
            this.alamat,
            this.no_telp,
            this.tgl_daftar,
            this.status_anggota,
            this.Update,
            this.Delete});
            this.dgvMember.DataSource = this.msmemberBindingSource;
            this.dgvMember.DoubleBuffered = true;
            this.dgvMember.EnableHeadersVisualStyles = false;
            this.dgvMember.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.dgvMember.HeaderForeColor = System.Drawing.Color.White;
            this.dgvMember.Location = new System.Drawing.Point(453, 686);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(878, 170);
            this.dgvMember.TabIndex = 90;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellContentClick);
            // 
            // id_member
            // 
            this.id_member.DataPropertyName = "id_member";
            this.id_member.HeaderText = "id_member";
            this.id_member.MinimumWidth = 10;
            this.id_member.Name = "id_member";
            this.id_member.ReadOnly = true;
            this.id_member.Width = 200;
            // 
            // nama_member
            // 
            this.nama_member.DataPropertyName = "nama_member";
            this.nama_member.HeaderText = "nama_member";
            this.nama_member.MinimumWidth = 10;
            this.nama_member.Name = "nama_member";
            this.nama_member.ReadOnly = true;
            this.nama_member.Width = 200;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "alamat";
            this.alamat.MinimumWidth = 10;
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            this.alamat.Width = 200;
            // 
            // no_telp
            // 
            this.no_telp.DataPropertyName = "no_telp";
            this.no_telp.HeaderText = "no_telp";
            this.no_telp.MinimumWidth = 10;
            this.no_telp.Name = "no_telp";
            this.no_telp.ReadOnly = true;
            this.no_telp.Width = 200;
            // 
            // tgl_daftar
            // 
            this.tgl_daftar.DataPropertyName = "tgl_daftar";
            this.tgl_daftar.HeaderText = "tgl_daftar";
            this.tgl_daftar.MinimumWidth = 10;
            this.tgl_daftar.Name = "tgl_daftar";
            this.tgl_daftar.ReadOnly = true;
            this.tgl_daftar.Width = 200;
            // 
            // status_anggota
            // 
            this.status_anggota.DataPropertyName = "status_anggota";
            this.status_anggota.HeaderText = "status_anggota";
            this.status_anggota.MinimumWidth = 10;
            this.status_anggota.Name = "status_anggota";
            this.status_anggota.ReadOnly = true;
            this.status_anggota.Width = 200;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Image = global::Renzone.Properties.Resources.pencil__2_;
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.ToolTipText = "Edit Data";
            this.Update.Width = 70;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::Renzone.Properties.Resources.icons8_delete_90;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.ToolTipText = "Hapus Data";
            this.Delete.Width = 70;
            // 
            // msmemberBindingSource
            // 
            this.msmemberBindingSource.DataMember = "ms_member";
            this.msmemberBindingSource.DataSource = this.renzonDataSet1;
            // 
            // renzonDataSet1
            // 
            this.renzonDataSet1.DataSetName = "RenzonDataSet1";
            this.renzonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddCat
            // 
            this.btnAddCat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCat.Image = null;
            this.btnAddCat.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddCat.Location = new System.Drawing.Point(976, 364);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.OnHoverImage = null;
            this.btnAddCat.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddCat.Size = new System.Drawing.Size(54, 33);
            this.btnAddCat.TabIndex = 89;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(518, 253);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(197, 36);
            this.gunaLabel5.TabIndex = 88;
            this.gunaLabel5.Text = "Alamat";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(519, 304);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(196, 45);
            this.gunaLabel4.TabIndex = 86;
            this.gunaLabel4.Text = "Regis Date";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(519, 187);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(196, 45);
            this.gunaLabel3.TabIndex = 85;
            this.gunaLabel3.Text = "Name";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(519, 361);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(196, 45);
            this.gunaLabel2.TabIndex = 84;
            this.gunaLabel2.Text = "No Telp";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(519, 132);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(196, 45);
            this.gunaLabel1.TabIndex = 83;
            this.gunaLabel1.Text = "ID Member";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Enabled = false;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1117, 87);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 25;
            this.gunaButton1.Size = new System.Drawing.Size(221, 55);
            this.gunaButton1.TabIndex = 82;
            this.gunaButton1.Text = "GAMES";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(475, 142);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 105;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(475, 198);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 104;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(475, 373);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 103;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(475, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(475, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCancel.Location = new System.Drawing.Point(614, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 15;
            this.btnCancel.Size = new System.Drawing.Size(119, 42);
            this.btnCancel.TabIndex = 92;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btSave
            // 
            this.btSave.AnimationHoverSpeed = 0.07F;
            this.btSave.AnimationSpeed = 0.03F;
            this.btSave.BackColor = System.Drawing.Color.Transparent;
            this.btSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btSave.BorderColor = System.Drawing.Color.Black;
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btSave.FocusedColor = System.Drawing.Color.Empty;
            this.btSave.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btSave.Location = new System.Drawing.Point(865, 450);
            this.btSave.Name = "btSave";
            this.btSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btSave.OnHoverImage = null;
            this.btSave.OnPressedColor = System.Drawing.Color.Black;
            this.btSave.Radius = 15;
            this.btSave.Size = new System.Drawing.Size(119, 42);
            this.btSave.TabIndex = 91;
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btnMenuAcc
            // 
            this.btnMenuAcc.AnimationHoverSpeed = 0.07F;
            this.btnMenuAcc.AnimationSpeed = 0.03F;
            this.btnMenuAcc.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuAcc.BorderColor = System.Drawing.Color.Black;
            this.btnMenuAcc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuAcc.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenuAcc.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAcc.ForeColor = System.Drawing.Color.White;
            this.btnMenuAcc.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuAcc.Image")));
            this.btnMenuAcc.ImageOffsetX = 20;
            this.btnMenuAcc.ImageSize = new System.Drawing.Size(27, 24);
            this.btnMenuAcc.Location = new System.Drawing.Point(12, 698);
            this.btnMenuAcc.Name = "btnMenuAcc";
            this.btnMenuAcc.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuAcc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuAcc.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuAcc.OnHoverImage = null;
            this.btnMenuAcc.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuAcc.Size = new System.Drawing.Size(329, 59);
            this.btnMenuAcc.TabIndex = 87;
            this.btnMenuAcc.Text = "Accessories";
            this.btnMenuAcc.TextOffsetX = 30;
            // 
            // btnMenuPS
            // 
            this.btnMenuPS.AnimationHoverSpeed = 0.07F;
            this.btnMenuPS.AnimationSpeed = 0.03F;
            this.btnMenuPS.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuPS.BorderColor = System.Drawing.Color.Black;
            this.btnMenuPS.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuPS.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenuPS.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPS.ForeColor = System.Drawing.Color.White;
            this.btnMenuPS.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPS.Image")));
            this.btnMenuPS.ImageOffsetX = 20;
            this.btnMenuPS.ImageSize = new System.Drawing.Size(26, 23);
            this.btnMenuPS.Location = new System.Drawing.Point(12, 633);
            this.btnMenuPS.Name = "btnMenuPS";
            this.btnMenuPS.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuPS.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuPS.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuPS.OnHoverImage = null;
            this.btnMenuPS.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuPS.Size = new System.Drawing.Size(329, 59);
            this.btnMenuPS.TabIndex = 81;
            this.btnMenuPS.Text = "Play Station";
            this.btnMenuPS.TextOffsetX = 30;
            // 
            // btnMenuMember
            // 
            this.btnMenuMember.AnimationHoverSpeed = 0.07F;
            this.btnMenuMember.AnimationSpeed = 0.03F;
            this.btnMenuMember.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuMember.BorderColor = System.Drawing.Color.Black;
            this.btnMenuMember.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuMember.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenuMember.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMember.ForeColor = System.Drawing.Color.White;
            this.btnMenuMember.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuMember.Image")));
            this.btnMenuMember.ImageOffsetX = 20;
            this.btnMenuMember.ImageSize = new System.Drawing.Size(23, 25);
            this.btnMenuMember.Location = new System.Drawing.Point(12, 570);
            this.btnMenuMember.Name = "btnMenuMember";
            this.btnMenuMember.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuMember.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuMember.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuMember.OnHoverImage = null;
            this.btnMenuMember.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuMember.Size = new System.Drawing.Size(329, 59);
            this.btnMenuMember.TabIndex = 80;
            this.btnMenuMember.Text = "Member";
            this.btnMenuMember.TextOffsetX = 30;
            // 
            // btnMenuPackage
            // 
            this.btnMenuPackage.AnimationHoverSpeed = 0.07F;
            this.btnMenuPackage.AnimationSpeed = 0.03F;
            this.btnMenuPackage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuPackage.BorderColor = System.Drawing.Color.Black;
            this.btnMenuPackage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuPackage.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenuPackage.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPackage.ForeColor = System.Drawing.Color.White;
            this.btnMenuPackage.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPackage.Image")));
            this.btnMenuPackage.ImageOffsetX = 20;
            this.btnMenuPackage.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMenuPackage.Location = new System.Drawing.Point(12, 510);
            this.btnMenuPackage.Name = "btnMenuPackage";
            this.btnMenuPackage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuPackage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuPackage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuPackage.OnHoverImage = null;
            this.btnMenuPackage.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuPackage.Size = new System.Drawing.Size(329, 59);
            this.btnMenuPackage.TabIndex = 79;
            this.btnMenuPackage.Text = "Package/Service";
            this.btnMenuPackage.TextOffsetX = 30;
            // 
            // btnMenuTable
            // 
            this.btnMenuTable.AnimationHoverSpeed = 0.07F;
            this.btnMenuTable.AnimationSpeed = 0.03F;
            this.btnMenuTable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuTable.BorderColor = System.Drawing.Color.Black;
            this.btnMenuTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuTable.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenuTable.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTable.ForeColor = System.Drawing.Color.White;
            this.btnMenuTable.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuTable.Image")));
            this.btnMenuTable.ImageOffsetX = 20;
            this.btnMenuTable.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMenuTable.Location = new System.Drawing.Point(12, 451);
            this.btnMenuTable.Name = "btnMenuTable";
            this.btnMenuTable.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuTable.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuTable.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuTable.OnHoverImage = null;
            this.btnMenuTable.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuTable.Size = new System.Drawing.Size(329, 59);
            this.btnMenuTable.TabIndex = 78;
            this.btnMenuTable.Text = "Tables";
            this.btnMenuTable.TextOffsetX = 30;
            // 
            // btnMenuCategory
            // 
            this.btnMenuCategory.AnimationHoverSpeed = 0.07F;
            this.btnMenuCategory.AnimationSpeed = 0.03F;
            this.btnMenuCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuCategory.BorderColor = System.Drawing.Color.Black;
            this.btnMenuCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenuCategory.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCategory.ForeColor = System.Drawing.Color.White;
            this.btnMenuCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuCategory.Image")));
            this.btnMenuCategory.ImageOffsetX = 20;
            this.btnMenuCategory.ImageSize = new System.Drawing.Size(26, 26);
            this.btnMenuCategory.Location = new System.Drawing.Point(12, 386);
            this.btnMenuCategory.Name = "btnMenuCategory";
            this.btnMenuCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuCategory.OnHoverImage = null;
            this.btnMenuCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuCategory.Size = new System.Drawing.Size(329, 59);
            this.btnMenuCategory.TabIndex = 77;
            this.btnMenuCategory.Text = "Games Category";
            this.btnMenuCategory.TextOffsetX = 30;
            // 
            // btnMenuGame
            // 
            this.btnMenuGame.AnimationHoverSpeed = 0.07F;
            this.btnMenuGame.AnimationSpeed = 0.03F;
            this.btnMenuGame.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuGame.BorderColor = System.Drawing.Color.Black;
            this.btnMenuGame.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuGame.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenuGame.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuGame.ForeColor = System.Drawing.Color.White;
            this.btnMenuGame.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuGame.Image")));
            this.btnMenuGame.ImageOffsetX = 20;
            this.btnMenuGame.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMenuGame.Location = new System.Drawing.Point(12, 321);
            this.btnMenuGame.Name = "btnMenuGame";
            this.btnMenuGame.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMenuGame.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuGame.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuGame.OnHoverImage = null;
            this.btnMenuGame.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuGame.Size = new System.Drawing.Size(329, 59);
            this.btnMenuGame.TabIndex = 76;
            this.btnMenuGame.Text = "Games";
            this.btnMenuGame.TextOffsetX = 30;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageOffsetX = 20;
            this.btnDashboard.ImageSize = new System.Drawing.Size(28, 28);
            this.btnDashboard.Location = new System.Drawing.Point(12, 256);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Size = new System.Drawing.Size(329, 59);
            this.btnDashboard.TabIndex = 75;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffsetX = 30;
            // 
            // ms_memberTableAdapter
            // 
            this.ms_memberTableAdapter.ClearBeforeFill = true;
            // 
            // tbTanggalM
            // 
            this.tbTanggalM.BaseColor = System.Drawing.Color.White;
            this.tbTanggalM.BorderColor = System.Drawing.Color.Silver;
            this.tbTanggalM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTanggalM.FocusedBaseColor = System.Drawing.Color.White;
            this.tbTanggalM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbTanggalM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTanggalM.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTanggalM.Location = new System.Drawing.Point(721, 304);
            this.tbTanggalM.Name = "tbTanggalM";
            this.tbTanggalM.PasswordChar = '\0';
            this.tbTanggalM.SelectedText = "";
            this.tbTanggalM.Size = new System.Drawing.Size(326, 47);
            this.tbTanggalM.TabIndex = 106;
            // 
            // CRUDMember
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Renzone.Properties.Resources.CRUD__1_;
            this.ClientSize = new System.Drawing.Size(1460, 891);
            this.Controls.Add(this.tbTanggalM);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbValidasi);
            this.Controls.Add(this.tbAlamatM);
            this.Controls.Add(this.tbTelpM);
            this.Controls.Add(this.tbNamaM);
            this.Controls.Add(this.tbIDM);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.btnMenuAcc);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.btnMenuPS);
            this.Controls.Add(this.btnMenuMember);
            this.Controls.Add(this.btnMenuPackage);
            this.Controls.Add(this.btnMenuTable);
            this.Controls.Add(this.btnMenuCategory);
            this.Controls.Add(this.btnMenuGame);
            this.Controls.Add(this.btnDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDMember";
            this.ShowInTaskbar = false;
            this.Text = "CRUDMember";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CRUDMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renzonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel lbValidasi;
        private Guna.UI.WinForms.GunaTextBox tbAlamatM;
        private Guna.UI.WinForms.GunaTextBox tbTelpM;
        private Guna.UI.WinForms.GunaTextBox tbNamaM;
        private Guna.UI.WinForms.GunaTextBox tbIDM;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaLineTextBox tbSearch;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private Guna.UI.WinForms.GunaButton btSave;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvMember;
        private Guna.UI.WinForms.GunaImageButton btnAddCat;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton btnMenuAcc;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton btnMenuPS;
        private Guna.UI.WinForms.GunaButton btnMenuMember;
        private Guna.UI.WinForms.GunaButton btnMenuPackage;
        private Guna.UI.WinForms.GunaButton btnMenuTable;
        private Guna.UI.WinForms.GunaButton btnMenuCategory;
        private Guna.UI.WinForms.GunaButton btnMenuGame;
        private Guna.UI.WinForms.GunaButton btnDashboard;
        private RenzonDataSet1 renzonDataSet1;
        private System.Windows.Forms.BindingSource msmemberBindingSource;
        private RenzonDataSet1TableAdapters.ms_memberTableAdapter ms_memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_telp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_daftar;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_anggota;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private Guna.UI.WinForms.GunaTextBox tbTanggalM;
    }
}