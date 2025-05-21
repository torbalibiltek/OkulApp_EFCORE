namespace OkulApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbSiniflar = new ListBox();
            label1 = new Label();
            txtSinif = new TextBox();
            btnEkleGuncelle = new Button();
            btnSil = new Button();
            btnYeni = new Button();
            dataGridView1 = new DataGridView();
            ColNumara = new DataGridViewTextBoxColumn();
            ColAd = new DataGridViewTextBoxColumn();
            ColSoyad = new DataGridViewTextBoxColumn();
            ColCinsiyet = new DataGridViewComboBoxColumn();
            ColSinif = new DataGridViewComboBoxColumn();
            btnOgrencileriGuncelle = new Button();
            btnOgrenciSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbSiniflar
            // 
            lbSiniflar.FormattingEnabled = true;
            lbSiniflar.ItemHeight = 15;
            lbSiniflar.Location = new Point(12, 30);
            lbSiniflar.Name = "lbSiniflar";
            lbSiniflar.Size = new Size(160, 259);
            lbSiniflar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Sınıflar";
            // 
            // txtSinif
            // 
            txtSinif.Location = new Point(13, 296);
            txtSinif.Name = "txtSinif";
            txtSinif.Size = new Size(159, 23);
            txtSinif.TabIndex = 2;
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.Location = new Point(14, 333);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(92, 23);
            btnEkleGuncelle.TabIndex = 3;
            btnEkleGuncelle.Text = "Ekle/Güncelle";
            btnEkleGuncelle.UseVisualStyleBackColor = true;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(112, 333);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(58, 23);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYeni
            // 
            btnYeni.Location = new Point(14, 362);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(58, 23);
            btnYeni.TabIndex = 3;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNumara, ColAd, ColSoyad, ColCinsiyet, ColSinif });
            dataGridView1.Location = new Point(178, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(589, 289);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // ColNumara
            // 
            ColNumara.DataPropertyName = "Numara";
            ColNumara.HeaderText = "Numara";
            ColNumara.Name = "ColNumara";
            // 
            // ColAd
            // 
            ColAd.DataPropertyName = "Ad";
            ColAd.HeaderText = "Ad";
            ColAd.Name = "ColAd";
            // 
            // ColSoyad
            // 
            ColSoyad.DataPropertyName = "Soyad";
            ColSoyad.HeaderText = "Soyad";
            ColSoyad.Name = "ColSoyad";
            // 
            // ColCinsiyet
            // 
            ColCinsiyet.DataPropertyName = "Cinsiyet";
            ColCinsiyet.HeaderText = "Cinsiyet";
            ColCinsiyet.Name = "ColCinsiyet";
            // 
            // ColSinif
            // 
            ColSinif.DataPropertyName = "SinifId";
            ColSinif.HeaderText = "Sınıf";
            ColSinif.Name = "ColSinif";
            // 
            // btnOgrencileriGuncelle
            // 
            btnOgrencileriGuncelle.Location = new Point(567, 325);
            btnOgrencileriGuncelle.Name = "btnOgrencileriGuncelle";
            btnOgrencileriGuncelle.Size = new Size(75, 23);
            btnOgrencileriGuncelle.TabIndex = 5;
            btnOgrencileriGuncelle.Text = "Güncelle";
            btnOgrencileriGuncelle.UseVisualStyleBackColor = true;
            btnOgrencileriGuncelle.Click += btnOgrencileriGuncelle_Click;
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.Location = new Point(486, 325);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(75, 23);
            btnOgrenciSil.TabIndex = 6;
            btnOgrenciSil.Text = "Sil";
            btnOgrenciSil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(882, 428);
            Controls.Add(btnOgrenciSil);
            Controls.Add(btnOgrencileriGuncelle);
            Controls.Add(dataGridView1);
            Controls.Add(btnYeni);
            Controls.Add(btnSil);
            Controls.Add(btnEkleGuncelle);
            Controls.Add(txtSinif);
            Controls.Add(label1);
            Controls.Add(lbSiniflar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbSiniflar;
        private Label label1;
        private TextBox txtSinif;
        private Button btnEkleGuncelle;
        private Button btnSil;
        private Button btnYeni;
        private DataGridView dataGridView1;
        private Button btnOgrencileriGuncelle;
        private Button btnOgrenciSil;
        private DataGridViewTextBoxColumn ColNumara;
        private DataGridViewTextBoxColumn ColAd;
        private DataGridViewTextBoxColumn ColSoyad;
        private DataGridViewComboBoxColumn ColCinsiyet;
        private DataGridViewComboBoxColumn ColSinif;
    }
}
