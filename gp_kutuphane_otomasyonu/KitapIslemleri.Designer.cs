﻿namespace gp_kutuphane_otomasyonu
{
    partial class frm_KitapIslemleri
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
            this.label14 = new System.Windows.Forms.Label();
            this.txt_kitap_adedi = new System.Windows.Forms.TextBox();
            this.btn_kitap_guncelle = new System.Windows.Forms.Button();
            this.btn_kitap_sil = new System.Windows.Forms.Button();
            this.btn_kitap_ekle = new System.Windows.Forms.Button();
            this.DG_kitap_Listesi = new System.Windows.Forms.DataGridView();
            this.txt_kitap_sayfa_sayisi = new System.Windows.Forms.TextBox();
            this.txt_kitap_aciklama = new System.Windows.Forms.TextBox();
            this.txt_kitap_turu = new System.Windows.Forms.TextBox();
            this.txt_kitap_basim_yili = new System.Windows.Forms.TextBox();
            this.txt_kitap_adi = new System.Windows.Forms.TextBox();
            this.txt_kitap_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DG_Emanet_Tablosu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_kitap_Listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Emanet_Tablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Kitap Adedi";
            // 
            // txt_kitap_adedi
            // 
            this.txt_kitap_adedi.Location = new System.Drawing.Point(130, 294);
            this.txt_kitap_adedi.Name = "txt_kitap_adedi";
            this.txt_kitap_adedi.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_adedi.TabIndex = 46;
            // 
            // btn_kitap_guncelle
            // 
            this.btn_kitap_guncelle.Location = new System.Drawing.Point(36, 490);
            this.btn_kitap_guncelle.Name = "btn_kitap_guncelle";
            this.btn_kitap_guncelle.Size = new System.Drawing.Size(247, 51);
            this.btn_kitap_guncelle.TabIndex = 45;
            this.btn_kitap_guncelle.Text = "Kitap Güncelle";
            this.btn_kitap_guncelle.UseVisualStyleBackColor = true;
            this.btn_kitap_guncelle.Click += new System.EventHandler(this.btn_kitap_guncelle_Click);
            // 
            // btn_kitap_sil
            // 
            this.btn_kitap_sil.Location = new System.Drawing.Point(36, 416);
            this.btn_kitap_sil.Name = "btn_kitap_sil";
            this.btn_kitap_sil.Size = new System.Drawing.Size(247, 51);
            this.btn_kitap_sil.TabIndex = 44;
            this.btn_kitap_sil.Text = "Kitap Sil";
            this.btn_kitap_sil.UseVisualStyleBackColor = true;
            this.btn_kitap_sil.Click += new System.EventHandler(this.btn_kitap_sil_Click);
            // 
            // btn_kitap_ekle
            // 
            this.btn_kitap_ekle.Location = new System.Drawing.Point(36, 340);
            this.btn_kitap_ekle.Name = "btn_kitap_ekle";
            this.btn_kitap_ekle.Size = new System.Drawing.Size(247, 51);
            this.btn_kitap_ekle.TabIndex = 43;
            this.btn_kitap_ekle.Text = "Kitap Ekle";
            this.btn_kitap_ekle.UseVisualStyleBackColor = true;
            this.btn_kitap_ekle.Click += new System.EventHandler(this.btn_kitap_ekle_Click);
            // 
            // DG_kitap_Listesi
            // 
            this.DG_kitap_Listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_kitap_Listesi.Location = new System.Drawing.Point(332, 30);
            this.DG_kitap_Listesi.Name = "DG_kitap_Listesi";
            this.DG_kitap_Listesi.Size = new System.Drawing.Size(934, 284);
            this.DG_kitap_Listesi.TabIndex = 42;
            this.DG_kitap_Listesi.SelectionChanged += new System.EventHandler(this.DG_kitap_Listesi_SelectionChanged);
            // 
            // txt_kitap_sayfa_sayisi
            // 
            this.txt_kitap_sayfa_sayisi.Location = new System.Drawing.Point(130, 250);
            this.txt_kitap_sayfa_sayisi.Name = "txt_kitap_sayfa_sayisi";
            this.txt_kitap_sayfa_sayisi.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_sayfa_sayisi.TabIndex = 41;
            // 
            // txt_kitap_aciklama
            // 
            this.txt_kitap_aciklama.Location = new System.Drawing.Point(130, 206);
            this.txt_kitap_aciklama.Name = "txt_kitap_aciklama";
            this.txt_kitap_aciklama.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_aciklama.TabIndex = 40;
            // 
            // txt_kitap_turu
            // 
            this.txt_kitap_turu.Location = new System.Drawing.Point(130, 162);
            this.txt_kitap_turu.Name = "txt_kitap_turu";
            this.txt_kitap_turu.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_turu.TabIndex = 39;
            // 
            // txt_kitap_basim_yili
            // 
            this.txt_kitap_basim_yili.Location = new System.Drawing.Point(130, 118);
            this.txt_kitap_basim_yili.Name = "txt_kitap_basim_yili";
            this.txt_kitap_basim_yili.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_basim_yili.TabIndex = 38;
            // 
            // txt_kitap_adi
            // 
            this.txt_kitap_adi.Location = new System.Drawing.Point(130, 74);
            this.txt_kitap_adi.Name = "txt_kitap_adi";
            this.txt_kitap_adi.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_adi.TabIndex = 37;
            // 
            // txt_kitap_id
            // 
            this.txt_kitap_id.Location = new System.Drawing.Point(130, 30);
            this.txt_kitap_id.Name = "txt_kitap_id";
            this.txt_kitap_id.Size = new System.Drawing.Size(153, 20);
            this.txt_kitap_id.TabIndex = 36;
            this.txt_kitap_id.TextChanged += new System.EventHandler(this.txt_kitap_id_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Kitap Sayfa Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Kitap Türü";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Kitap Açıklama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Kitap Basım Yılı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Kitap Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Kitap ID";
            // 
            // DG_Emanet_Tablosu
            // 
            this.DG_Emanet_Tablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Emanet_Tablosu.Location = new System.Drawing.Point(332, 340);
            this.DG_Emanet_Tablosu.Name = "DG_Emanet_Tablosu";
            this.DG_Emanet_Tablosu.Size = new System.Drawing.Size(934, 201);
            this.DG_Emanet_Tablosu.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Kitap Tablosu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Seçili Kitabı Kiralayanlar Tablosu";
            // 
            // frm_KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 590);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_Emanet_Tablosu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_kitap_adedi);
            this.Controls.Add(this.btn_kitap_guncelle);
            this.Controls.Add(this.btn_kitap_sil);
            this.Controls.Add(this.btn_kitap_ekle);
            this.Controls.Add(this.DG_kitap_Listesi);
            this.Controls.Add(this.txt_kitap_sayfa_sayisi);
            this.Controls.Add(this.txt_kitap_aciklama);
            this.Controls.Add(this.txt_kitap_turu);
            this.Controls.Add(this.txt_kitap_basim_yili);
            this.Controls.Add(this.txt_kitap_adi);
            this.Controls.Add(this.txt_kitap_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Name = "frm_KitapIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.frm_KitapIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_kitap_Listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Emanet_Tablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_kitap_adedi;
        private System.Windows.Forms.Button btn_kitap_guncelle;
        private System.Windows.Forms.Button btn_kitap_sil;
        private System.Windows.Forms.Button btn_kitap_ekle;
        private System.Windows.Forms.DataGridView DG_kitap_Listesi;
        private System.Windows.Forms.TextBox txt_kitap_sayfa_sayisi;
        private System.Windows.Forms.TextBox txt_kitap_aciklama;
        private System.Windows.Forms.TextBox txt_kitap_turu;
        private System.Windows.Forms.TextBox txt_kitap_basim_yili;
        private System.Windows.Forms.TextBox txt_kitap_adi;
        private System.Windows.Forms.TextBox txt_kitap_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DG_Emanet_Tablosu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}