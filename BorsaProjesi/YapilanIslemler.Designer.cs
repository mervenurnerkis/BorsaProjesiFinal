namespace BorsaProjesi
{
    partial class YapilanIslemler
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
            this.dataGridIslemler = new System.Windows.Forms.DataGridView();
            this.yazilimYapimiDataSet = new BorsaProjesi.YazilimYapimiDataSet();
            this.islemzamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemdetayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harcanantutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alicikalanpara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIslemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridIslemler
            // 
            this.dataGridIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIslemler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemzamani,
            this.islemdetayi,
            this.harcanantutar,
            this.birimfiyat,
            this.alicikalanpara});
            this.dataGridIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridIslemler.Location = new System.Drawing.Point(0, 0);
            this.dataGridIslemler.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridIslemler.Name = "dataGridIslemler";
            this.dataGridIslemler.RowHeadersWidth = 51;
            this.dataGridIslemler.Size = new System.Drawing.Size(1214, 692);
            this.dataGridIslemler.TabIndex = 0;
            // 
            // yazilimYapimiDataSet
            // 
            this.yazilimYapimiDataSet.DataSetName = "YazilimYapimiDataSet";
            this.yazilimYapimiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // islemzamani
            // 
            this.islemzamani.HeaderText = "Tarih-Saat";
            this.islemzamani.MinimumWidth = 6;
            this.islemzamani.Name = "islemzamani";
            // 
            // islemdetayi
            // 
            this.islemdetayi.HeaderText = "İşlem Bilgisi";
            this.islemdetayi.MinimumWidth = 6;
            this.islemdetayi.Name = "islemdetayi";
            // 
            // harcanantutar
            // 
            this.harcanantutar.HeaderText = "Harcanan Para";
            this.harcanantutar.MinimumWidth = 6;
            this.harcanantutar.Name = "harcanantutar";
            // 
            // birimfiyat
            // 
            this.birimfiyat.HeaderText = "Satılan Mahsulun Birim Fiyatı";
            this.birimfiyat.MinimumWidth = 6;
            this.birimfiyat.Name = "birimfiyat";
            // 
            // alicikalanpara
            // 
            this.alicikalanpara.HeaderText = "Kalan Para";
            this.alicikalanpara.MinimumWidth = 6;
            this.alicikalanpara.Name = "alicikalanpara";
            // 
            // YapilanIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1214, 692);
            this.Controls.Add(this.dataGridIslemler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "YapilanIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yapılan Islemler";
            this.Load += new System.EventHandler(this.YapilanIslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIslemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridIslemler;
        //private Islemler ıslemler1;
        private YazilimYapimiDataSet yazilimYapimiDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemzamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemdetayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn harcanantutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn alicikalanpara;
    }
}