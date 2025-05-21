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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(669, 428);
            Controls.Add(btnYeni);
            Controls.Add(btnSil);
            Controls.Add(btnEkleGuncelle);
            Controls.Add(txtSinif);
            Controls.Add(label1);
            Controls.Add(lbSiniflar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
