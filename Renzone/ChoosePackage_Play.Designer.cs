namespace Renzone
{
    partial class ChoosePackage_Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosePackage_Play));
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.nama_paket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNext = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.cbMeja = new Guna.UI.WinForms.GunaComboBox();
            this.cbJam = new Guna.UI.WinForms.GunaComboBox();
            this.cbTanggal = new Guna.UI.WinForms.GunaComboBox();
            this.btnPrev = new Guna.UI.WinForms.GunaButton();
            this.lblWelcome = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 27;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_paket,
            this.durasi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(179, 322);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(403, 337);
            this.gunaDataGridView1.TabIndex = 11;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // nama_paket
            // 
            this.nama_paket.HeaderText = "Package Name";
            this.nama_paket.MinimumWidth = 6;
            this.nama_paket.Name = "nama_paket";
            // 
            // durasi
            // 
            this.durasi.HeaderText = "Durasi";
            this.durasi.MinimumWidth = 6;
            this.durasi.Name = "durasi";
            // 
            // btnNext
            // 
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.btnNext.BorderColor = System.Drawing.Color.Black;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageOffsetX = 15;
            this.btnNext.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNext.Location = new System.Drawing.Point(1132, 722);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext.OnHoverImage = null;
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Radius = 20;
            this.btnNext.Size = new System.Drawing.Size(160, 43);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.TextOffsetX = 20;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.gunaPictureBox3);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Controls.Add(this.cbMeja);
            this.gunaPanel1.Controls.Add(this.cbJam);
            this.gunaPanel1.Controls.Add(this.cbTanggal);
            this.gunaPanel1.Location = new System.Drawing.Point(937, 296);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(344, 388);
            this.gunaPanel1.TabIndex = 9;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Location = new System.Drawing.Point(305, 135);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(35, 24);
            this.gunaPictureBox3.TabIndex = 7;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Location = new System.Drawing.Point(306, 217);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(21, 21);
            this.gunaPictureBox2.TabIndex = 6;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(306, 46);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(21, 21);
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // cbMeja
            // 
            this.cbMeja.BackColor = System.Drawing.Color.Transparent;
            this.cbMeja.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cbMeja.BorderColor = System.Drawing.Color.Black;
            this.cbMeja.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeja.FocusedColor = System.Drawing.Color.Empty;
            this.cbMeja.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMeja.ForeColor = System.Drawing.Color.Black;
            this.cbMeja.FormattingEnabled = true;
            this.cbMeja.Location = new System.Drawing.Point(14, 209);
            this.cbMeja.Name = "cbMeja";
            this.cbMeja.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMeja.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMeja.Radius = 10;
            this.cbMeja.Size = new System.Drawing.Size(275, 31);
            this.cbMeja.TabIndex = 4;
            // 
            // cbJam
            // 
            this.cbJam.BackColor = System.Drawing.Color.Transparent;
            this.cbJam.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cbJam.BorderColor = System.Drawing.Color.Black;
            this.cbJam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbJam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJam.FocusedColor = System.Drawing.Color.Empty;
            this.cbJam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbJam.ForeColor = System.Drawing.Color.Black;
            this.cbJam.FormattingEnabled = true;
            this.cbJam.Location = new System.Drawing.Point(14, 129);
            this.cbJam.Name = "cbJam";
            this.cbJam.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbJam.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbJam.Radius = 10;
            this.cbJam.Size = new System.Drawing.Size(275, 31);
            this.cbJam.TabIndex = 3;
            // 
            // cbTanggal
            // 
            this.cbTanggal.BackColor = System.Drawing.Color.Transparent;
            this.cbTanggal.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cbTanggal.BorderColor = System.Drawing.Color.Black;
            this.cbTanggal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTanggal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTanggal.FocusedColor = System.Drawing.Color.Empty;
            this.cbTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTanggal.ForeColor = System.Drawing.Color.Black;
            this.cbTanggal.FormattingEnabled = true;
            this.cbTanggal.Location = new System.Drawing.Point(14, 40);
            this.cbTanggal.Name = "cbTanggal";
            this.cbTanggal.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTanggal.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTanggal.Radius = 10;
            this.cbTanggal.Size = new System.Drawing.Size(275, 31);
            this.cbTanggal.TabIndex = 2;
            // 
            // btnPrev
            // 
            this.btnPrev.AnimationHoverSpeed = 0.07F;
            this.btnPrev.AnimationSpeed = 0.03F;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.btnPrev.BorderColor = System.Drawing.Color.Black;
            this.btnPrev.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrev.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrev.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageOffsetX = 15;
            this.btnPrev.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrev.Location = new System.Drawing.Point(176, 722);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPrev.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrev.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrev.OnHoverImage = null;
            this.btnPrev.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrev.Radius = 20;
            this.btnPrev.Size = new System.Drawing.Size(160, 43);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "Prev";
            this.btnPrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrev.TextOffsetX = 20;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1440, 40);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Renzone.Properties.Resources.Pilih_Paket;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btnPrev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_paket;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasi;
        private Guna.UI.WinForms.GunaButton btnNext;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaComboBox cbMeja;
        private Guna.UI.WinForms.GunaComboBox cbJam;
        private Guna.UI.WinForms.GunaComboBox cbTanggal;
        private Guna.UI.WinForms.GunaButton btnPrev;
        private Guna.UI.WinForms.GunaLabel lblWelcome;
    }
}