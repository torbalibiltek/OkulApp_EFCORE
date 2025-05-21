using Microsoft.EntityFrameworkCore;
using OkulApp.Modeller;

namespace OkulApp
{
    public partial class Form1 : Form
    {
        //global scope
        OkulDataContext db = new();
        //global scope
        public Form1()
        {
            InitializeComponent();

            ColCinsiyet.DataSource = new List<CinsiyetItem>
            {

                new CinsiyetItem() { Cinsiyet = "Erkek" },
                 new CinsiyetItem() { Cinsiyet = "Kad�n" }
            };

            ColCinsiyet.DisplayMember = "Cinsiyet"; //Combobox'ta g�sterilecek alan
            ColCinsiyet.ValueMember = "Id"; //Combobox'ta de�eri belirle
        }

        void VerileriYukle()
        {
            //local scope
            db.Siniflar.Load(); //Veritaban�ndaki s�n�flar� y�kle

            //var liste = db.Siniflar.ToList(); //Veritaban�ndaki s�n�flar� listele
            var liste = db.Siniflar.Local.ToBindingList(); //Veritaban�ndaki s�n�flar� listele
            lbSiniflar.DataSource = liste; //Listeyi liste kutusuna ata
            lbSiniflar.DisplayMember = "SinifAdi"; //Liste kutusundaki g�sterilecek alan� belirle
            lbSiniflar.ValueMember = "Id"; //Liste kutusundaki de�eri belirle
                                           //local scope 


            //Siniflar Combobox� doldur
            ColSinif.DataSource = liste; //Liste kutusundaki s�n�flar� ata
            ColSinif.DisplayMember = "SinifAdi"; //Liste kutusundaki g�sterilecek alan� belirle
            ColSinif.ValueMember = "Id"; //Liste kutusundaki de�eri belirle

            //��rencileri y�kle
            dataGridView1.AutoGenerateColumns = false;
            db.Ogrenciler.Load(); //Veritaban�ndaki ��rencileri y�kle
            var ogrenciListe = db.Ogrenciler.Local.ToBindingList(); //Veritaban�ndaki ��rencileri listele
            dataGridView1.DataSource = ogrenciListe; //Listeyi veri gridine ata

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriYukle(); //Form y�klendi�inde verileri y�kle
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            //1-Ekleme (Listede bir�ey se�ili de�ilse)
            //2-G�ncelleme (Listede se�ili s�n�f var ise)

            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Se�ili s�n�f� al

            if (secili == null)
            {
                DbSinif yeniSinif = new();
                yeniSinif.SinifAdi = txtSinif.Text; //S�n�f ad�n� al

                db.Siniflar.Add(yeniSinif); //S�n�f� ekle
                db.SaveChanges(); //De�i�iklikleri kaydet
                MessageBox.Show("Yeni s�n�f eklendi.");
            }
            else
            {
                secili.SinifAdi = txtSinif.Text; //Se�ili s�n�f�n ad�n� g�ncelle
                db.SaveChanges(); //De�i�iklikleri kaydet
                db.Siniflar.Local.ToBindingList().ResetBindings(); //Listeyi g�ncelle
                MessageBox.Show("S�n�f g�ncellendi.");
            }

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            lbSiniflar.SelectedIndex = -1; //Liste kutusundaki se�ili ��eyi kald�r
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Se�ili s�n�f� al

            if (secili != null)
            {
                var cevap = MessageBox.Show($"{secili.SinifAdi} adl� s�n�f� silmek " +
                    $"istedi�inze emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    db.Siniflar.Remove(secili);
                    db.SaveChanges();
                    MessageBox.Show("S�n�f silindi.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnOgrencileriGuncelle_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            int seciliIndex = dataGridView1.CurrentRow.Index;

            if (seciliIndex < 0)
                return;

            DbOgrenci ogr = dataGridView1.Rows[seciliIndex].DataBoundItem as DbOgrenci;

            var cevap = MessageBox.Show($"{ogr.Numara} {ogr.Ad} {ogr.Soyad} adl� ��renciyi silmek " +
                    $"istedi�inze emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                db.Ogrenciler.Remove(ogr);
                db.SaveChanges();
                MessageBox.Show("��renci silindi.");
            }
        }
    }
}
