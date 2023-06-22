namespace RenZone_Transaksi
{
    partial class AddCategory
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnOK = new Guna.UI.WinForms.GunaButton();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.lbValidasi = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(363, 231);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(42, 64);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(209, 129);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // lbCategory
            // 
            this.lbCategory.BackColor = System.Drawing.Color.White;
            this.lbCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCategory.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(80)))));
            this.lbCategory.Location = new System.Drawing.Point(0, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(291, 44);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Game Categories";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.AnimationHoverSpeed = 0.07F;
            this.btnOK.AnimationSpeed = 0.03F;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(205)))), ((int)(((byte)(78)))));
            this.btnOK.BorderColor = System.Drawing.Color.Black;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.FocusedColor = System.Drawing.Color.Empty;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = null;
            this.btnOK.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOK.Location = new System.Drawing.Point(169, 201);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOK.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOK.OnHoverImage = null;
            this.btnOK.OnPressedColor = System.Drawing.Color.Black;
            this.btnOK.Radius = 10;
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Red;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Linen;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(55, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 10;
            this.btnCancel.Size = new System.Drawing.Size(65, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbValidasi
            // 
            this.lbValidasi.AutoSize = true;
            this.lbValidasi.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidasi.ForeColor = System.Drawing.Color.Red;
            this.lbValidasi.Location = new System.Drawing.Point(23, 244);
            this.lbValidasi.Name = "lbValidasi";
            this.lbValidasi.Size = new System.Drawing.Size(247, 15);
            this.lbValidasi.TabIndex = 4;
            this.lbValidasi.Text = "Pilih setidaknya 1 kategori !!";
            this.lbValidasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbValidasi.Visible = false;
            // 
            // AddCategory
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 265);
            this.Controls.Add(this.lbValidasi);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1126, 301);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCategory;
        private Guna.UI.WinForms.GunaButton btnOK;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private Guna.UI.WinForms.GunaLabel lbValidasi;
    }
}