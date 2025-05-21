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
                 new CinsiyetItem() { Cinsiyet = "Kadýn" }
            };

            ColCinsiyet.DisplayMember = "Cinsiyet"; //Combobox'ta gösterilecek alan
            ColCinsiyet.ValueMember = "Id"; //Combobox'ta deðeri belirle
        }

        void VerileriYukle()
        {
            //local scope
            db.Siniflar.Load(); //Veritabanýndaki sýnýflarý yükle

            //var liste = db.Siniflar.ToList(); //Veritabanýndaki sýnýflarý listele
            var liste = db.Siniflar.Local.ToBindingList(); //Veritabanýndaki sýnýflarý listele
            lbSiniflar.DataSource = liste; //Listeyi liste kutusuna ata
            lbSiniflar.DisplayMember = "SinifAdi"; //Liste kutusundaki gösterilecek alaný belirle
            lbSiniflar.ValueMember = "Id"; //Liste kutusundaki deðeri belirle
                                           //local scope 


            //Siniflar Comboboxý doldur
            ColSinif.DataSource = liste; //Liste kutusundaki sýnýflarý ata
            ColSinif.DisplayMember = "SinifAdi"; //Liste kutusundaki gösterilecek alaný belirle
            ColSinif.ValueMember = "Id"; //Liste kutusundaki deðeri belirle

            //Öðrencileri yükle
            dataGridView1.AutoGenerateColumns = false;
            db.Ogrenciler.Load(); //Veritabanýndaki öðrencileri yükle
            var ogrenciListe = db.Ogrenciler.Local.ToBindingList(); //Veritabanýndaki öðrencileri listele
            dataGridView1.DataSource = ogrenciListe; //Listeyi veri gridine ata

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriYukle(); //Form yüklendiðinde verileri yükle
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            //1-Ekleme (Listede birþey seçili deðilse)
            //2-Güncelleme (Listede seçili sýnýf var ise)

            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Seçili sýnýfý al

            if (secili == null)
            {
                DbSinif yeniSinif = new();
                yeniSinif.SinifAdi = txtSinif.Text; //Sýnýf adýný al

                db.Siniflar.Add(yeniSinif); //Sýnýfý ekle
                db.SaveChanges(); //Deðiþiklikleri kaydet
                MessageBox.Show("Yeni sýnýf eklendi.");
            }
            else
            {
                secili.SinifAdi = txtSinif.Text; //Seçili sýnýfýn adýný güncelle
                db.SaveChanges(); //Deðiþiklikleri kaydet
                db.Siniflar.Local.ToBindingList().ResetBindings(); //Listeyi güncelle
                MessageBox.Show("Sýnýf güncellendi.");
            }

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            lbSiniflar.SelectedIndex = -1; //Liste kutusundaki seçili öðeyi kaldýr
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Seçili sýnýfý al

            if (secili != null)
            {
                var cevap = MessageBox.Show($"{secili.SinifAdi} adlý sýnýfý silmek " +
                    $"istediðinze emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    db.Siniflar.Remove(secili);
                    db.SaveChanges();
                    MessageBox.Show("Sýnýf silindi.");
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

            var cevap = MessageBox.Show($"{ogr.Numara} {ogr.Ad} {ogr.Soyad} adlý öðrenciyi silmek " +
                    $"istediðinze emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                db.Ogrenciler.Remove(ogr);
                db.SaveChanges();
                MessageBox.Show("Öðrenci silindi.");
            }
        }
    }
}
