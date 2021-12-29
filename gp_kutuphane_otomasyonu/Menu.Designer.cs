namespace gp_kutuphane_otomasyonu
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.lbl_ogr = new System.Windows.Forms.Label();
            this.lbl_kitapislemleri = new System.Windows.Forms.Label();
            this.lbl_kitapverme = new System.Windows.Forms.Label();
            this.lbl_kitaptakibi = new System.Windows.Forms.Label();
            this.btn_kitap_takibi = new System.Windows.Forms.PictureBox();
            this.btn_kitap_verme = new System.Windows.Forms.PictureBox();
            this.btn_kitap_islemleri = new System.Windows.Forms.PictureBox();
            this.btn_ogrenci_islemleri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kitap_takibi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kitap_verme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kitap_islemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ogrenci_islemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ogr
            // 
            this.lbl_ogr.AutoSize = true;
            this.lbl_ogr.Location = new System.Drawing.Point(45, 213);
            this.lbl_ogr.Name = "lbl_ogr";
            this.lbl_ogr.Size = new System.Drawing.Size(84, 13);
            this.lbl_ogr.TabIndex = 8;
            this.lbl_ogr.Text = "Öğrenci İşlemleri";
            this.lbl_ogr.Click += new System.EventHandler(this.lbl_ogr_Click);
            // 
            // lbl_kitapislemleri
            // 
            this.lbl_kitapislemleri.AutoSize = true;
            this.lbl_kitapislemleri.Location = new System.Drawing.Point(239, 213);
            this.lbl_kitapislemleri.Name = "lbl_kitapislemleri";
            this.lbl_kitapislemleri.Size = new System.Drawing.Size(71, 13);
            this.lbl_kitapislemleri.TabIndex = 9;
            this.lbl_kitapislemleri.Text = "Kitap İşlemleri";
            this.lbl_kitapislemleri.Click += new System.EventHandler(this.lbl_kitapislemleri_Click);
            // 
            // lbl_kitapverme
            // 
            this.lbl_kitapverme.AutoSize = true;
            this.lbl_kitapverme.Location = new System.Drawing.Point(397, 213);
            this.lbl_kitapverme.Name = "lbl_kitapverme";
            this.lbl_kitapverme.Size = new System.Drawing.Size(99, 13);
            this.lbl_kitapverme.TabIndex = 10;
            this.lbl_kitapverme.Text = "Kitap Ödünç Verme";
            this.lbl_kitapverme.Click += new System.EventHandler(this.lbl_kitapverme_Click);
            // 
            // lbl_kitaptakibi
            // 
            this.lbl_kitaptakibi.AutoSize = true;
            this.lbl_kitaptakibi.Location = new System.Drawing.Point(605, 213);
            this.lbl_kitaptakibi.Name = "lbl_kitaptakibi";
            this.lbl_kitaptakibi.Size = new System.Drawing.Size(63, 13);
            this.lbl_kitaptakibi.TabIndex = 11;
            this.lbl_kitaptakibi.Text = "Kitap Takibi";
            this.lbl_kitaptakibi.Click += new System.EventHandler(this.lbl_kitaptakibi_Click);
            // 
            // btn_kitap_takibi
            // 
            this.btn_kitap_takibi.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitap_takibi.Image")));
            this.btn_kitap_takibi.Location = new System.Drawing.Point(540, 0);
            this.btn_kitap_takibi.Name = "btn_kitap_takibi";
            this.btn_kitap_takibi.Size = new System.Drawing.Size(180, 240);
            this.btn_kitap_takibi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_kitap_takibi.TabIndex = 7;
            this.btn_kitap_takibi.TabStop = false;
            this.btn_kitap_takibi.Click += new System.EventHandler(this.btn_kitap_takibi_Click);
            // 
            // btn_kitap_verme
            // 
            this.btn_kitap_verme.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitap_verme.Image")));
            this.btn_kitap_verme.Location = new System.Drawing.Point(360, 0);
            this.btn_kitap_verme.Name = "btn_kitap_verme";
            this.btn_kitap_verme.Size = new System.Drawing.Size(180, 240);
            this.btn_kitap_verme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_kitap_verme.TabIndex = 6;
            this.btn_kitap_verme.TabStop = false;
            this.btn_kitap_verme.Click += new System.EventHandler(this.btn_kitap_verme_Click);
            // 
            // btn_kitap_islemleri
            // 
            this.btn_kitap_islemleri.Image = ((System.Drawing.Image)(resources.GetObject("btn_kitap_islemleri.Image")));
            this.btn_kitap_islemleri.Location = new System.Drawing.Point(180, 0);
            this.btn_kitap_islemleri.Name = "btn_kitap_islemleri";
            this.btn_kitap_islemleri.Size = new System.Drawing.Size(180, 240);
            this.btn_kitap_islemleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_kitap_islemleri.TabIndex = 5;
            this.btn_kitap_islemleri.TabStop = false;
            this.btn_kitap_islemleri.Click += new System.EventHandler(this.btn_kitap_islemleri_Click);
            // 
            // btn_ogrenci_islemleri
            // 
            this.btn_ogrenci_islemleri.Image = ((System.Drawing.Image)(resources.GetObject("btn_ogrenci_islemleri.Image")));
            this.btn_ogrenci_islemleri.Location = new System.Drawing.Point(0, 0);
            this.btn_ogrenci_islemleri.Name = "btn_ogrenci_islemleri";
            this.btn_ogrenci_islemleri.Size = new System.Drawing.Size(180, 240);
            this.btn_ogrenci_islemleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ogrenci_islemleri.TabIndex = 4;
            this.btn_ogrenci_islemleri.TabStop = false;
            this.btn_ogrenci_islemleri.Click += new System.EventHandler(this.btn_ogrenci_islemleri_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 240);
            this.Controls.Add(this.lbl_kitaptakibi);
            this.Controls.Add(this.lbl_kitapverme);
            this.Controls.Add(this.lbl_kitapislemleri);
            this.Controls.Add(this.lbl_ogr);
            this.Controls.Add(this.btn_kitap_takibi);
            this.Controls.Add(this.btn_kitap_verme);
            this.Controls.Add(this.btn_kitap_islemleri);
            this.Controls.Add(this.btn_ogrenci_islemleri);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            ((System.ComponentModel.ISupportInitialize)(this.btn_kitap_takibi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kitap_verme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kitap_islemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ogrenci_islemleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_ogrenci_islemleri;
        private System.Windows.Forms.PictureBox btn_kitap_islemleri;
        private System.Windows.Forms.PictureBox btn_kitap_verme;
        private System.Windows.Forms.PictureBox btn_kitap_takibi;
        private System.Windows.Forms.Label lbl_ogr;
        private System.Windows.Forms.Label lbl_kitapislemleri;
        private System.Windows.Forms.Label lbl_kitapverme;
        private System.Windows.Forms.Label lbl_kitaptakibi;
    }
}