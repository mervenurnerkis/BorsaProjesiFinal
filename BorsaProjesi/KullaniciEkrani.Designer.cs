namespace BorsaProjesi
{
    partial class KullaniciEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkrani));
            this.cmbUrunTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlisTalep = new System.Windows.Forms.Button();
            this.btnOnay = new System.Windows.Forms.Button();
            this.tbbirimfiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmiktar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBxBakiye = new System.Windows.Forms.ComboBox();
            this.btnOnayaGonder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblbakiye = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listUrun = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listAlisTalep = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblbakiyeonay = new System.Windows.Forms.Label();
            this.btnRapor = new System.Windows.Forms.Button();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbbirimfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmiktar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUrunTipi
            // 
            this.cmbUrunTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunTipi.ForeColor = System.Drawing.Color.Maroon;
            this.cmbUrunTipi.FormattingEnabled = true;
            this.cmbUrunTipi.Items.AddRange(new object[] {
            "Buğday",
            "Arpa",
            "Yulaf",
            "Petrol",
            "Pamuk"});
            this.cmbUrunTipi.Location = new System.Drawing.Point(124, 19);
            this.cmbUrunTipi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUrunTipi.Name = "cmbUrunTipi";
            this.cmbUrunTipi.Size = new System.Drawing.Size(176, 28);
            this.cmbUrunTipi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Tipi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlisTalep);
            this.groupBox1.Controls.Add(this.btnOnay);
            this.groupBox1.Controls.Add(this.tbbirimfiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbmiktar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbUrunTipi);
            this.groupBox1.Location = new System.Drawing.Point(10, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(349, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnAlisTalep
            // 
            this.btnAlisTalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlisTalep.ForeColor = System.Drawing.Color.Maroon;
            this.btnAlisTalep.Location = new System.Drawing.Point(11, 97);
            this.btnAlisTalep.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlisTalep.Name = "btnAlisTalep";
            this.btnAlisTalep.Size = new System.Drawing.Size(144, 28);
            this.btnAlisTalep.TabIndex = 4;
            this.btnAlisTalep.Text = "Alış Talebi Gönder";
            this.btnAlisTalep.UseVisualStyleBackColor = true;
            this.btnAlisTalep.Click += new System.EventHandler(this.btnAlisTalep_Click);
            // 
            // btnOnay
            // 
            this.btnOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.ForeColor = System.Drawing.Color.Maroon;
            this.btnOnay.Location = new System.Drawing.Point(163, 97);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(177, 28);
            this.btnOnay.TabIndex = 3;
            this.btnOnay.Text = "Onaya Gönder";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // tbbirimfiyat
            // 
            this.tbbirimfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbbirimfiyat.ForeColor = System.Drawing.Color.Maroon;
            this.tbbirimfiyat.Location = new System.Drawing.Point(272, 58);
            this.tbbirimfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.tbbirimfiyat.Name = "tbbirimfiyat";
            this.tbbirimfiyat.Size = new System.Drawing.Size(52, 27);
            this.tbbirimfiyat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(169, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birim Fiyat:";
            // 
            // tbmiktar
            // 
            this.tbmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbmiktar.ForeColor = System.Drawing.Color.Maroon;
            this.tbmiktar.Location = new System.Drawing.Point(109, 54);
            this.tbmiktar.Margin = new System.Windows.Forms.Padding(4);
            this.tbmiktar.Name = "tbmiktar";
            this.tbmiktar.Size = new System.Drawing.Size(52, 27);
            this.tbmiktar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(41, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBxBakiye);
            this.groupBox2.Controls.Add(this.btnOnayaGonder);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBakiye);
            this.groupBox2.Location = new System.Drawing.Point(10, 454);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(349, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cmbBxBakiye
            // 
            this.cmbBxBakiye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBxBakiye.ForeColor = System.Drawing.Color.Maroon;
            this.cmbBxBakiye.FormattingEnabled = true;
            this.cmbBxBakiye.Items.AddRange(new object[] {
            "Euro",
            "Dolar",
            "Sterlin",
            "Türk Lirası"});
            this.cmbBxBakiye.Location = new System.Drawing.Point(199, 20);
            this.cmbBxBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxBakiye.Name = "cmbBxBakiye";
            this.cmbBxBakiye.Size = new System.Drawing.Size(115, 28);
            this.cmbBxBakiye.TabIndex = 4;
            // 
            // btnOnayaGonder
            // 
            this.btnOnayaGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayaGonder.ForeColor = System.Drawing.Color.Maroon;
            this.btnOnayaGonder.Location = new System.Drawing.Point(96, 56);
            this.btnOnayaGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnayaGonder.Name = "btnOnayaGonder";
            this.btnOnayaGonder.Size = new System.Drawing.Size(214, 28);
            this.btnOnayaGonder.TabIndex = 3;
            this.btnOnayaGonder.Text = "Onaya Gönder";
            this.btnOnayaGonder.UseVisualStyleBackColor = true;
            this.btnOnayaGonder.Click += new System.EventHandler(this.btnOnayaGonder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Para:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBakiye.ForeColor = System.Drawing.Color.Maroon;
            this.txtBakiye.Location = new System.Drawing.Point(100, 20);
            this.txtBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(91, 27);
            this.txtBakiye.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(31, 558);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Param: ";
            // 
            // lblbakiye
            // 
            this.lblbakiye.AutoSize = true;
            this.lblbakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbakiye.ForeColor = System.Drawing.Color.Maroon;
            this.lblbakiye.Location = new System.Drawing.Point(107, 558);
            this.lblbakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbakiye.Name = "lblbakiye";
            this.lblbakiye.Size = new System.Drawing.Size(38, 20);
            this.lblbakiye.TabIndex = 5;
            this.lblbakiye.Text = "0TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(548, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "ÜRÜNLERİM";
            // 
            // listUrun
            // 
            this.listUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrun.ForeColor = System.Drawing.Color.Maroon;
            this.listUrun.FormattingEnabled = true;
            this.listUrun.ItemHeight = 20;
            this.listUrun.Location = new System.Drawing.Point(386, 98);
            this.listUrun.Margin = new System.Windows.Forms.Padding(4);
            this.listUrun.Name = "listUrun";
            this.listUrun.Size = new System.Drawing.Size(453, 124);
            this.listUrun.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(518, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "ALIŞ TALEPLERİM";
            // 
            // listAlisTalep
            // 
            this.listAlisTalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listAlisTalep.ForeColor = System.Drawing.Color.Maroon;
            this.listAlisTalep.FormattingEnabled = true;
            this.listAlisTalep.ItemHeight = 20;
            this.listAlisTalep.Location = new System.Drawing.Point(386, 277);
            this.listAlisTalep.Margin = new System.Windows.Forms.Padding(4);
            this.listAlisTalep.Name = "listAlisTalep";
            this.listAlisTalep.Size = new System.Drawing.Size(453, 124);
            this.listAlisTalep.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(29, 591);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Onay Bekleyen:";
            // 
            // lblbakiyeonay
            // 
            this.lblbakiyeonay.AutoSize = true;
            this.lblbakiyeonay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbakiyeonay.ForeColor = System.Drawing.Color.Maroon;
            this.lblbakiyeonay.Location = new System.Drawing.Point(163, 591);
            this.lblbakiyeonay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbakiyeonay.Name = "lblbakiyeonay";
            this.lblbakiyeonay.Size = new System.Drawing.Size(38, 20);
            this.lblbakiyeonay.TabIndex = 5;
            this.lblbakiyeonay.Text = "0TL";
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ForeColor = System.Drawing.Color.Maroon;
            this.btnRapor.Location = new System.Drawing.Point(50, 156);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(4);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(170, 28);
            this.btnRapor.TabIndex = 3;
            this.btnRapor.Text = "Rapor Al";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeBaslangic.Location = new System.Drawing.Point(7, 46);
            this.dateTimeBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(239, 27);
            this.dateTimeBaslangic.TabIndex = 7;
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeBitis.Location = new System.Drawing.Point(7, 114);
            this.dateTimeBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(239, 27);
            this.dateTimeBitis.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(47, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Başlangıç Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(47, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bitiş Tarihi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimeBitis);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnRapor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dateTimeBaslangic);
            this.groupBox3.Location = new System.Drawing.Point(490, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 203);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(109, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "ÜRÜN EKLE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(109, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "PARA EKLE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // KullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(871, 623);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listAlisTalep);
            this.Controls.Add(this.listUrun);
            this.Controls.Add(this.lblbakiyeonay);
            this.Controls.Add(this.lblbakiye);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekranı";
            this.Load += new System.EventHandler(this.KullaniciEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbbirimfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmiktar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUrunTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.NumericUpDown tbmiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbbirimfiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOnayaGonder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Button btnAlisTalep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblbakiye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listUrun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listAlisTalep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblbakiyeonay;
        private System.Windows.Forms.ComboBox cmbBxBakiye;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}