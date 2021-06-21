namespace BorsaProjesi
{
    partial class YoneticiEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiEkrani));
            this.listKullanicilar = new System.Windows.Forms.ListBox();
            this.btnBakiyeOnay = new System.Windows.Forms.Button();
            this.listUrunTalep = new System.Windows.Forms.ListBox();
            this.labelBakiyetalep = new System.Windows.Forms.Label();
            this.lbltalep = new System.Windows.Forms.Label();
            this.labeluruntalepleri = new System.Windows.Forms.Label();
            this.btnTalep = new System.Windows.Forms.Button();
            this.lblKullanicilar = new System.Windows.Forms.Label();
            this.btnIslemler = new System.Windows.Forms.Button();
            this.btnDovizGuncelle = new System.Windows.Forms.Button();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxOrganik = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrganik)).BeginInit();
            this.SuspendLayout();
            // 
            // listKullanicilar
            // 
            this.listKullanicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listKullanicilar.ForeColor = System.Drawing.Color.Maroon;
            this.listKullanicilar.FormattingEnabled = true;
            this.listKullanicilar.ItemHeight = 20;
            this.listKullanicilar.Location = new System.Drawing.Point(289, 57);
            this.listKullanicilar.Margin = new System.Windows.Forms.Padding(4);
            this.listKullanicilar.Name = "listKullanicilar";
            this.listKullanicilar.Size = new System.Drawing.Size(400, 164);
            this.listKullanicilar.TabIndex = 0;
            this.listKullanicilar.SelectedIndexChanged += new System.EventHandler(this.listKullanicilar_SelectedIndexChanged);
            // 
            // btnBakiyeOnay
            // 
            this.btnBakiyeOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakiyeOnay.ForeColor = System.Drawing.Color.Maroon;
            this.btnBakiyeOnay.Location = new System.Drawing.Point(482, 235);
            this.btnBakiyeOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnBakiyeOnay.Name = "btnBakiyeOnay";
            this.btnBakiyeOnay.Size = new System.Drawing.Size(192, 37);
            this.btnBakiyeOnay.TabIndex = 1;
            this.btnBakiyeOnay.Text = "Bakiyeyi Onayla";
            this.btnBakiyeOnay.UseVisualStyleBackColor = true;
            this.btnBakiyeOnay.Click += new System.EventHandler(this.btnBakiyeOnay_Click);
            // 
            // listUrunTalep
            // 
            this.listUrunTalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrunTalep.ForeColor = System.Drawing.Color.DarkRed;
            this.listUrunTalep.FormattingEnabled = true;
            this.listUrunTalep.ItemHeight = 20;
            this.listUrunTalep.Location = new System.Drawing.Point(24, 375);
            this.listUrunTalep.Margin = new System.Windows.Forms.Padding(4);
            this.listUrunTalep.Name = "listUrunTalep";
            this.listUrunTalep.Size = new System.Drawing.Size(665, 124);
            this.listUrunTalep.TabIndex = 0;
            // 
            // labelBakiyetalep
            // 
            this.labelBakiyetalep.AutoSize = true;
            this.labelBakiyetalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBakiyetalep.ForeColor = System.Drawing.Color.Maroon;
            this.labelBakiyetalep.Location = new System.Drawing.Point(306, 243);
            this.labelBakiyetalep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBakiyetalep.Name = "labelBakiyetalep";
            this.labelBakiyetalep.Size = new System.Drawing.Size(119, 20);
            this.labelBakiyetalep.TabIndex = 2;
            this.labelBakiyetalep.Text = "Bakiye Talebi :";
            // 
            // lbltalep
            // 
            this.lbltalep.AutoSize = true;
            this.lbltalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltalep.ForeColor = System.Drawing.Color.Maroon;
            this.lbltalep.Location = new System.Drawing.Point(424, 243);
            this.lbltalep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltalep.Name = "lbltalep";
            this.lbltalep.Size = new System.Drawing.Size(38, 20);
            this.lbltalep.TabIndex = 2;
            this.lbltalep.Text = "0TL";
            // 
            // labeluruntalepleri
            // 
            this.labeluruntalepleri.AutoSize = true;
            this.labeluruntalepleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeluruntalepleri.ForeColor = System.Drawing.Color.Crimson;
            this.labeluruntalepleri.Location = new System.Drawing.Point(237, 342);
            this.labeluruntalepleri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeluruntalepleri.Name = "labeluruntalepleri";
            this.labeluruntalepleri.Size = new System.Drawing.Size(181, 29);
            this.labeluruntalepleri.TabIndex = 2;
            this.labeluruntalepleri.Text = "Ürün Talepleri";
            // 
            // btnTalep
            // 
            this.btnTalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTalep.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTalep.Location = new System.Drawing.Point(52, 522);
            this.btnTalep.Margin = new System.Windows.Forms.Padding(4);
            this.btnTalep.Name = "btnTalep";
            this.btnTalep.Size = new System.Drawing.Size(401, 39);
            this.btnTalep.TabIndex = 1;
            this.btnTalep.Text = "Talepleri Onayla";
            this.btnTalep.UseVisualStyleBackColor = true;
            this.btnTalep.Click += new System.EventHandler(this.btnTalep_Click);
            // 
            // lblKullanicilar
            // 
            this.lblKullanicilar.AutoSize = true;
            this.lblKullanicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanicilar.ForeColor = System.Drawing.Color.Crimson;
            this.lblKullanicilar.Location = new System.Drawing.Point(403, 21);
            this.lblKullanicilar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullanicilar.Name = "lblKullanicilar";
            this.lblKullanicilar.Size = new System.Drawing.Size(168, 32);
            this.lblKullanicilar.TabIndex = 2;
            this.lblKullanicilar.Text = "Kullanıcılar";
            // 
            // btnIslemler
            // 
            this.btnIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnIslemler.Location = new System.Drawing.Point(459, 520);
            this.btnIslemler.Margin = new System.Windows.Forms.Padding(4);
            this.btnIslemler.Name = "btnIslemler";
            this.btnIslemler.Size = new System.Drawing.Size(192, 41);
            this.btnIslemler.TabIndex = 1;
            this.btnIslemler.Text = "İşlem Detayları";
            this.btnIslemler.UseVisualStyleBackColor = true;
            this.btnIslemler.Click += new System.EventHandler(this.btnIslemler_Click);
            // 
            // btnDovizGuncelle
            // 
            this.btnDovizGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDovizGuncelle.ForeColor = System.Drawing.Color.Maroon;
            this.btnDovizGuncelle.Location = new System.Drawing.Point(13, 291);
            this.btnDovizGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDovizGuncelle.Name = "btnDovizGuncelle";
            this.btnDovizGuncelle.Size = new System.Drawing.Size(257, 34);
            this.btnDovizGuncelle.TabIndex = 1;
            this.btnDovizGuncelle.Text = " Döviz Tarihini Güncelle";
            this.btnDovizGuncelle.UseVisualStyleBackColor = true;
            this.btnDovizGuncelle.Click += new System.EventHandler(this.btnDovizGuncelle_Click);
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeTarih.Location = new System.Drawing.Point(13, 256);
            this.dateTimeTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(257, 27);
            this.dateTimeTarih.TabIndex = 3;
            // 
            // pictureBoxOrganik
            // 
            this.pictureBoxOrganik.BackColor = System.Drawing.Color.Pink;
            this.pictureBoxOrganik.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrganik.Image")));
            this.pictureBoxOrganik.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxOrganik.Name = "pictureBoxOrganik";
            this.pictureBoxOrganik.Size = new System.Drawing.Size(258, 234);
            this.pictureBoxOrganik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrganik.TabIndex = 5;
            this.pictureBoxOrganik.TabStop = false;
            // 
            // YoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(720, 586);
            this.Controls.Add(this.pictureBoxOrganik);
            this.Controls.Add(this.dateTimeTarih);
            this.Controls.Add(this.lbltalep);
            this.Controls.Add(this.labeluruntalepleri);
            this.Controls.Add(this.lblKullanicilar);
            this.Controls.Add(this.labelBakiyetalep);
            this.Controls.Add(this.btnDovizGuncelle);
            this.Controls.Add(this.btnTalep);
            this.Controls.Add(this.btnIslemler);
            this.Controls.Add(this.btnBakiyeOnay);
            this.Controls.Add(this.listUrunTalep);
            this.Controls.Add(this.listKullanicilar);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YoneticiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YoneticiEkrani_FormClosing);
            this.Load += new System.EventHandler(this.YoneticiEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrganik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listKullanicilar;
        private System.Windows.Forms.Button btnBakiyeOnay;
        private System.Windows.Forms.ListBox listUrunTalep;
        private System.Windows.Forms.Label labelBakiyetalep;
        private System.Windows.Forms.Label lbltalep;
        private System.Windows.Forms.Label labeluruntalepleri;
        private System.Windows.Forms.Button btnTalep;
        private System.Windows.Forms.Label lblKullanicilar;
        private System.Windows.Forms.Button btnIslemler;
        private System.Windows.Forms.Button btnDovizGuncelle;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.PictureBox pictureBoxOrganik;
    }
}